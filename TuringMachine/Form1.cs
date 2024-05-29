using TuringMachine.Element;
using Newtonsoft.Json;

namespace TuringMachine
{
    public partial class Form1 : Form
    {
        private int StateCount { get => Convert.ToInt32(CommandsCountBox.Value); set => CommandsCountBox.Value = value; }
        private int AlphabetLength { get => Convert.ToInt32(AlphabetLengthBox.Value); set => AlphabetLengthBox.Value = value; }

        private class TuringAction(string replacement, Actions action, int nextState)
        {
            public string Replacement { get; set; } = replacement;
            public Actions Action { get; set; } = action;
            public int NextState { get; set; } = nextState;
        }

        private class TuringProgramData
        {
            public List<string> Alphabet { get; set; } = [];
            public List<string> States { get; set; } = [];
            public List<List<TuringAction>> Program { get; } = [];

            public void Clear()
            {
                Alphabet.Clear();
                States.Clear();
                Program.Clear();
            }
        }

        enum Actions
        {
            N,
            L,
            R,
        };

        private class Karetka
        {
            public int Position { get; private set; } = -1;
            public int State { get; private set; } = 0;

            public void Left() => Position--;
            public void Right() => Position++;
            public void ChangeState(int newState) => State = newState;
        }

        private class LentaProcessor(List<LentaProcessor.LentaElement> lenta)
        {
            public class LentaElement(string value, int position)
            {
                public string Value { get; set; } = value;
                public int Position { get; } = position;
            }

            private List<LentaElement> Lenta { get; } = lenta;

            public string GetSymbol(int position)
            {
                var symbol = Lenta.OrderBy(item => item.Position).Where(item => item.Position == position).FirstOrDefault();
                if (symbol != null) return symbol.Value;
                return "#";
            }

            public void SetSymbol(LentaElement symbol)
            {
                int index = Lenta.FindIndex(item => item.Position == symbol.Position);
                if (index == -1) Lenta.Add(symbol);
                else Lenta[index] = symbol;
            }
        }

        private TuringProgramData TuringProgram { get; set; } = new();
        private LentaProcessor Lenta { get; set; } = new([new("1", 0), new("9", 1), new("9", 2), new("9", 3), new("9", 4)]);
        private Karetka Kar { get; } = new();

        public Form1()
        {
            InitializeComponent();

            InitLenta(Kar.Position);
            Kar.ChangeState(1);
            PrintInfo();
        }

        private void InitLenta(int currentPosition)
        {
            List<string> leftLenta = [];
            for (int i = currentPosition - 5; i < currentPosition; i++) leftLenta.Add(Lenta.GetSymbol(i));

            List<string> rightLenta = [];
            for (int i = currentPosition + 1; i < currentPosition + 6; i++) rightLenta.Add(Lenta.GetSymbol(i));

            CurrentLentaLabel.Text = Lenta.GetSymbol(currentPosition);
            LeftLentaLabel.Text = string.Join(" ", leftLenta);
            RightLentaLabel.Text = string.Join(" ", rightLenta);
        }

        private void Calculate()
        {
            if (Kar.State == 0)
            {
                MessageBox.Show("Программа завершилась", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                List<TuringAction> currentState = TuringProgram.Program[Kar.State - 1];
                string symbol = Lenta.GetSymbol(Kar.Position);

                int actionIndex = -1;
                for (int i = 0; i < TuringProgram.Alphabet.Count; i++) if (TuringProgram.Alphabet[i] == symbol) actionIndex = i;

                if (actionIndex != -1)
                {
                    var action = currentState[actionIndex];

                    Lenta.SetSymbol(new(action.Replacement, Kar.Position));
                    if (action.Action == Actions.L) Kar.Left();
                    else if (action.Action == Actions.R) Kar.Right();
                    Kar.ChangeState(action.NextState);
                }

                InitLenta(Kar.Position);
                PrintInfo();
            }
        }

        private void PrintInfo()
        {
            List<string> infoList = [
                "Состояние: " + Kar.State,
                "Позиция: " + Kar.Position,
            ];

            KaretkaInfoLabel.Text = string.Join(", ", infoList);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (StateCount <= 0 || AlphabetLength <= 0) return;
            TuringProgram.Clear();

            var alphabet = Enumerable.Range(0, AlphabetLength).Select(item => item.ToString("X")).ToList();
            alphabet.Insert(0, "#");
            TuringProgram.Alphabet = alphabet;

            var states = Enumerable.Range(1, StateCount).Select(i => i.ToString()).ToList();
            TuringProgram.States = states;

            for (int row = 0; row < StateCount; row++)
            {
                TuringProgram.Program.Add([]);
                for (int col = 0; col < AlphabetLength + 1; col++)
                {
                    TuringProgram.Program[row].Add(new TuringAction(alphabet[0], Actions.N, 0));
                }
            }
            BuildProgramMap();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenProgramDialog.InitialDirectory = Environment.CurrentDirectory;
            OpenProgramDialog.ShowDialog(this);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveProgramDialog.InitialDirectory = Environment.CurrentDirectory;
            SaveProgramDialog.ShowDialog(this);
        }

        private void BuildProgramMap()
        {
            AlphabetPanel.Controls.Clear();
            AlphabetPanel.RowCount = StateCount + 2;
            AlphabetPanel.ColumnCount = AlphabetLength + 2;

            float colWidth = AlphabetPanel.Width / AlphabetLength + 2;
            if (colWidth < 150) colWidth = 150;

            AlphabetPanel.ColumnStyles.Clear();
            AlphabetPanel.RowStyles.Clear();

            AlphabetPanel.RowStyles.Add(new(SizeType.AutoSize));
            for (int col = 0; col < TuringProgram.Alphabet.Count + 1; col++)
            {
                string text = "";
                if (col > 0) text = TuringProgram.Alphabet[col - 1];

                Label colName = new()
                {
                    Dock = DockStyle.Fill,
                    Text = text,
                    TextAlign = ContentAlignment.MiddleCenter,
                };

                AlphabetPanel.Controls.Add(colName, col, 0);
                AlphabetPanel.ColumnStyles.Add(new(SizeType.Absolute, colWidth));
            }

            for (int row = 1; row < TuringProgram.States.Count + 1; row++)
            {
                for (int col = 0; col < TuringProgram.Alphabet.Count + 1; col++)
                {
                    if (col == 0)
                    {
                        Label colName = new()
                        {
                            Dock = DockStyle.Fill,
                            Text = "Состояние " + row,
                            TextAlign = ContentAlignment.MiddleCenter,
                        };

                        AlphabetPanel.Controls.Add(colName, col, row);
                    }
                    else
                    {
                        FlowLayoutPanel flowPanel = new()
                        {
                            Width = (int)colWidth - 25,
                            BackColor = Color.Gray,
                            Margin = new(0),
                            Padding = new(0),
                            FlowDirection = FlowDirection.LeftToRight,
                            AutoSize = true,
                        };

                        float elemWidth = colWidth / 3;

                        CustomComboBox replaceBox = new(row - 1, col - 1)
                        {
                            Width = (int)elemWidth,
                            Margin = new(0),
                        };
                        TuringProgram.Alphabet.ForEach(s => replaceBox.Items.Add(s));
                        replaceBox.SelectedIndex = TuringProgram.Alphabet.IndexOf(TuringProgram.Program[row - 1][col - 1].Replacement);
                        replaceBox.SelectedIndexChanged += new((sender, args) =>
                        {
                            CustomComboBox box = sender as CustomComboBox ?? throw new Exception();
                            TuringProgram.Program[box.Row][box.Column].Replacement = replaceBox.SelectedItem?.ToString() ?? "";
                        });
                        flowPanel.Controls.Add(replaceBox);

                        CustomComboBox actionBox = new(row - 1, col - 1)
                        {
                            Width = (int)elemWidth,
                            Margin = new(0),
                        };
                        actionBox.Items.AddRange([Actions.N, Actions.L, Actions.R]);
                        actionBox.SelectedIndex = (int)TuringProgram.Program[row - 1][col - 1].Action;
                        actionBox.SelectedIndexChanged += new((sender, args) =>
                        {
                            CustomComboBox box = sender as CustomComboBox ?? throw new Exception();
                            TuringProgram.Program[box.Row][box.Column].Action = (Actions)actionBox.SelectedIndex;
                        });
                        flowPanel.Controls.Add(actionBox);

                        CustomComboBox statesBox = new(row - 1, col - 1)
                        {
                            Width = (int)elemWidth,
                            Margin = new(0),
                        };
                        statesBox.Items.AddRange([.. TuringProgram.States]);
                        statesBox.Items.Add("Выход");
                        statesBox.SelectedIndex = TuringProgram.Program[row - 1][col - 1].NextState == 0 ? (statesBox.Items.Count - 1) : TuringProgram.States.IndexOf(TuringProgram.Program[row - 1][col - 1].NextState.ToString());
                        statesBox.SelectedIndexChanged += new((sender, args) =>
                        {
                            CustomComboBox box = sender as CustomComboBox ?? throw new Exception();
                            string state = statesBox.SelectedItem?.ToString() ?? "";

                            if (state == "Выход") TuringProgram.Program[box.Row][box.Column].NextState = 0;
                            else TuringProgram.Program[box.Row][box.Column].NextState = Convert.ToInt32(state);
                        });
                        flowPanel.Controls.Add(statesBox);

                        AlphabetPanel.Controls.Add(flowPanel, col, row);
                    }

                    AlphabetPanel.RowStyles.Add(new(SizeType.AutoSize));
                }
            }

            AlphabetPanel.RowStyles.Add(new(SizeType.Percent, 100));
            AlphabetPanel.Refresh();
        }

        private void SaveProgramDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string filePath = SaveProgramDialog.FileName;
            File.WriteAllText(filePath, JsonConvert.SerializeObject(TuringProgram, Formatting.Indented));
        }

        private void OpenProgramDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string filePath = OpenProgramDialog.FileName;
            TuringProgram.Clear();
            TuringProgram = JsonConvert.DeserializeObject<TuringProgramData>(File.ReadAllText(filePath)) ?? new();

            AlphabetLength = TuringProgram.Alphabet.Count - 1;
            StateCount = TuringProgram.States.Count;

            BuildProgramMap();
        }

        private void StartTuringButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
