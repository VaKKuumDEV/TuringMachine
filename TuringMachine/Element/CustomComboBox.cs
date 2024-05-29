namespace TuringMachine.Element
{
    public class CustomComboBox(int row, int column) : ComboBox
    {
        public int Row { get; } = row;
        public int Column { get; set; } = column;
    }
}
