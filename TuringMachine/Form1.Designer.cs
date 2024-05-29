namespace TuringMachine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableLayoutPanel tableLayoutPanel1;
            TableLayoutPanel tableLayoutPanel2;
            Label label2;
            Label label1;
            TableLayoutPanel tableLayoutPanel3;
            TableLayoutPanel tableLayoutPanel4;
            TableLayoutPanel tableLayoutPanel5;
            Label label3;
            AlphabetLengthBox = new NumericUpDown();
            CommandsCountBox = new NumericUpDown();
            StartTuringButton = new Button();
            ExportButton = new Button();
            LoadButton = new Button();
            BuildButton = new Button();
            AlphabetPanel = new TableLayoutPanel();
            KaretkaInfoLabel = new Label();
            LentaLayout = new TableLayoutPanel();
            RightLentaLabel = new Label();
            CurrentLentaLabel = new Label();
            LeftLentaLabel = new Label();
            SaveProgramDialog = new SaveFileDialog();
            OpenProgramDialog = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlphabetLengthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommandsCountBox).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            LentaLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(AlphabetPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1039, 570);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(AlphabetLengthBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(CommandsCountBox, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1039, 60);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // AlphabetLengthBox
            // 
            AlphabetLengthBox.Dock = DockStyle.Top;
            AlphabetLengthBox.Location = new Point(522, 30);
            AlphabetLengthBox.Name = "AlphabetLengthBox";
            AlphabetLengthBox.Size = new Size(514, 27);
            AlphabetLengthBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(519, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(520, 27);
            label2.TabIndex = 1;
            label2.Text = "Длина алфавита";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(4);
            label1.Size = new Size(519, 27);
            label1.TabIndex = 0;
            label1.Text = "Число команд";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CommandsCountBox
            // 
            CommandsCountBox.Dock = DockStyle.Top;
            CommandsCountBox.Location = new Point(3, 30);
            CommandsCountBox.Name = "CommandsCountBox";
            CommandsCountBox.Size = new Size(513, 27);
            CommandsCountBox.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(StartTuringButton, 3, 0);
            tableLayoutPanel3.Controls.Add(ExportButton, 2, 0);
            tableLayoutPanel3.Controls.Add(LoadButton, 1, 0);
            tableLayoutPanel3.Controls.Add(BuildButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 526);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1039, 43);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // StartTuringButton
            // 
            StartTuringButton.AutoSize = true;
            StartTuringButton.Location = new Point(310, 3);
            StartTuringButton.Name = "StartTuringButton";
            StartTuringButton.Padding = new Padding(4);
            StartTuringButton.Size = new Size(98, 37);
            StartTuringButton.TabIndex = 3;
            StartTuringButton.Text = "Запустить";
            StartTuringButton.UseVisualStyleBackColor = true;
            StartTuringButton.Click += StartTuringButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.AutoSize = true;
            ExportButton.Location = new Point(206, 3);
            ExportButton.Name = "ExportButton";
            ExportButton.Padding = new Padding(4);
            ExportButton.Size = new Size(98, 37);
            ExportButton.TabIndex = 2;
            ExportButton.Text = "Выгрузить";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // LoadButton
            // 
            LoadButton.AutoSize = true;
            LoadButton.Location = new Point(106, 3);
            LoadButton.Name = "LoadButton";
            LoadButton.Padding = new Padding(4);
            LoadButton.Size = new Size(94, 37);
            LoadButton.TabIndex = 1;
            LoadButton.Text = "Загрузить";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += LoadButton_Click;
            // 
            // BuildButton
            // 
            BuildButton.AutoSize = true;
            BuildButton.Location = new Point(3, 3);
            BuildButton.Name = "BuildButton";
            BuildButton.Padding = new Padding(4);
            BuildButton.Size = new Size(97, 37);
            BuildButton.TabIndex = 0;
            BuildButton.Text = "Построить";
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // AlphabetPanel
            // 
            AlphabetPanel.AutoScroll = true;
            AlphabetPanel.ColumnCount = 1;
            AlphabetPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            AlphabetPanel.Dock = DockStyle.Fill;
            AlphabetPanel.Location = new Point(0, 60);
            AlphabetPanel.Margin = new Padding(0);
            AlphabetPanel.Name = "AlphabetPanel";
            AlphabetPanel.RowCount = 1;
            AlphabetPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            AlphabetPanel.Size = new Size(1039, 280);
            AlphabetPanel.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(LentaLayout, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 340);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(1039, 186);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label3, 1, 0);
            tableLayoutPanel5.Controls.Add(KaretkaInfoLabel, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 141);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(1039, 45);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Calibri", 22F, FontStyle.Bold);
            label3.Location = new Point(444, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Padding = new Padding(4);
            label3.Size = new Size(150, 45);
            label3.TabIndex = 0;
            label3.Text = "/\\";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KaretkaInfoLabel
            // 
            KaretkaInfoLabel.AutoSize = true;
            KaretkaInfoLabel.Dock = DockStyle.Fill;
            KaretkaInfoLabel.Location = new Point(594, 0);
            KaretkaInfoLabel.Margin = new Padding(0);
            KaretkaInfoLabel.Name = "KaretkaInfoLabel";
            KaretkaInfoLabel.Padding = new Padding(4);
            KaretkaInfoLabel.Size = new Size(445, 45);
            KaretkaInfoLabel.TabIndex = 1;
            KaretkaInfoLabel.Text = "label4";
            KaretkaInfoLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LentaLayout
            // 
            LentaLayout.ColumnCount = 3;
            LentaLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LentaLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            LentaLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LentaLayout.Controls.Add(RightLentaLabel, 2, 0);
            LentaLayout.Controls.Add(CurrentLentaLabel, 1, 0);
            LentaLayout.Controls.Add(LeftLentaLabel, 0, 0);
            LentaLayout.Dock = DockStyle.Fill;
            LentaLayout.Location = new Point(0, 0);
            LentaLayout.Margin = new Padding(0);
            LentaLayout.Name = "LentaLayout";
            LentaLayout.RowCount = 1;
            LentaLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LentaLayout.Size = new Size(1039, 141);
            LentaLayout.TabIndex = 1;
            // 
            // RightLentaLabel
            // 
            RightLentaLabel.AutoSize = true;
            RightLentaLabel.Dock = DockStyle.Fill;
            RightLentaLabel.Location = new Point(594, 0);
            RightLentaLabel.Margin = new Padding(0);
            RightLentaLabel.Name = "RightLentaLabel";
            RightLentaLabel.Padding = new Padding(4);
            RightLentaLabel.Size = new Size(445, 141);
            RightLentaLabel.TabIndex = 3;
            RightLentaLabel.Text = "#";
            RightLentaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CurrentLentaLabel
            // 
            CurrentLentaLabel.AutoSize = true;
            CurrentLentaLabel.Dock = DockStyle.Fill;
            CurrentLentaLabel.Font = new Font("Calibri", 22F, FontStyle.Bold);
            CurrentLentaLabel.Location = new Point(444, 0);
            CurrentLentaLabel.Margin = new Padding(0);
            CurrentLentaLabel.Name = "CurrentLentaLabel";
            CurrentLentaLabel.Padding = new Padding(4);
            CurrentLentaLabel.Size = new Size(150, 141);
            CurrentLentaLabel.TabIndex = 1;
            CurrentLentaLabel.Text = "#";
            CurrentLentaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LeftLentaLabel
            // 
            LeftLentaLabel.AutoSize = true;
            LeftLentaLabel.Dock = DockStyle.Fill;
            LeftLentaLabel.Location = new Point(0, 0);
            LeftLentaLabel.Margin = new Padding(0);
            LeftLentaLabel.Name = "LeftLentaLabel";
            LeftLentaLabel.Padding = new Padding(4);
            LeftLentaLabel.Size = new Size(444, 141);
            LeftLentaLabel.TabIndex = 2;
            LeftLentaLabel.Text = "#";
            LeftLentaLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SaveProgramDialog
            // 
            SaveProgramDialog.DefaultExt = "trt";
            SaveProgramDialog.Filter = "Turing files|*.trt";
            SaveProgramDialog.Title = "Выберите место сохранения";
            SaveProgramDialog.FileOk += SaveProgramDialog_FileOk;
            // 
            // OpenProgramDialog
            // 
            OpenProgramDialog.FileName = "openFileDialog1";
            OpenProgramDialog.FileOk += OpenProgramDialog_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1039, 570);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Calibri", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Машина Тьюринга";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AlphabetLengthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommandsCountBox).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            LentaLayout.ResumeLayout(false);
            LentaLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown AlphabetLengthBox;
        private NumericUpDown CommandsCountBox;
        private Button BuildButton;
        private TableLayoutPanel AlphabetPanel;
        private Button ExportButton;
        private Button LoadButton;
        private SaveFileDialog SaveProgramDialog;
        private OpenFileDialog OpenProgramDialog;
        private Button StartTuringButton;
        private TableLayoutPanel LentaLayout;
        private Label LeftLentaLabel;
        private Label RightLentaLabel;
        private Label CurrentLentaLabel;
        private Label KaretkaInfoLabel;
    }
}
