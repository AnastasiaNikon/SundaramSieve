
namespace SundaramSieve
{
    partial class FormSieve
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.valueNumeric = new System.Windows.Forms.NumericUpDown();
            this.вводЗначенияGroupBox = new System.Windows.Forms.GroupBox();
            this.введитеNLabel = new System.Windows.Forms.Label();
            this.кнопкиНавигацииGroupBox = new System.Windows.Forms.GroupBox();
            this.buildSieveButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.решетоGroupBox = new System.Windows.Forms.GroupBox();
            this.sieveDataGridView = new System.Windows.Forms.DataGridView();
            this.saveSieveButton = new System.Windows.Forms.Button();
            this.инструкцияGroupBox = new System.Windows.Forms.GroupBox();
            this.инструкцияLabel1 = new System.Windows.Forms.Label();
            this.инструкцияLabel2 = new System.Windows.Forms.Label();
            this.инструкцияLabel3 = new System.Windows.Forms.Label();
            this.инструкцияLabel4 = new System.Windows.Forms.Label();
            this.примечаниеLabel = new System.Windows.Forms.Label();
            this.инструкцияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).BeginInit();
            this.вводЗначенияGroupBox.SuspendLayout();
            this.кнопкиНавигацииGroupBox.SuspendLayout();
            this.решетоGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sieveDataGridView)).BeginInit();
            this.инструкцияGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // valueNumeric
            // 
            this.valueNumeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valueNumeric.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNumeric.Location = new System.Drawing.Point(171, 14);
            this.valueNumeric.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.valueNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueNumeric.Name = "valueNumeric";
            this.valueNumeric.Size = new System.Drawing.Size(59, 33);
            this.valueNumeric.TabIndex = 0;
            this.valueNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // вводЗначенияGroupBox
            // 
            this.вводЗначенияGroupBox.Controls.Add(this.введитеNLabel);
            this.вводЗначенияGroupBox.Controls.Add(this.valueNumeric);
            this.вводЗначенияGroupBox.Location = new System.Drawing.Point(12, 12);
            this.вводЗначенияGroupBox.Name = "вводЗначенияGroupBox";
            this.вводЗначенияGroupBox.Size = new System.Drawing.Size(236, 57);
            this.вводЗначенияGroupBox.TabIndex = 1;
            this.вводЗначенияGroupBox.TabStop = false;
            // 
            // введитеNLabel
            // 
            this.введитеNLabel.AutoSize = true;
            this.введитеNLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.введитеNLabel.Location = new System.Drawing.Point(6, 16);
            this.введитеNLabel.Name = "введитеNLabel";
            this.введитеNLabel.Size = new System.Drawing.Size(159, 25);
            this.введитеNLabel.TabIndex = 2;
            this.введитеNLabel.Text = "Введите N(1-50):";
            // 
            // кнопкиНавигацииGroupBox
            // 
            this.кнопкиНавигацииGroupBox.Controls.Add(this.aboutButton);
            this.кнопкиНавигацииGroupBox.Controls.Add(this.buildSieveButton);
            this.кнопкиНавигацииGroupBox.Location = new System.Drawing.Point(254, 12);
            this.кнопкиНавигацииGroupBox.Name = "кнопкиНавигацииGroupBox";
            this.кнопкиНавигацииGroupBox.Size = new System.Drawing.Size(534, 57);
            this.кнопкиНавигацииGroupBox.TabIndex = 2;
            this.кнопкиНавигацииGroupBox.TabStop = false;
            // 
            // buildSieveButton
            // 
            this.buildSieveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buildSieveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buildSieveButton.Location = new System.Drawing.Point(6, 14);
            this.buildSieveButton.Name = "buildSieveButton";
            this.buildSieveButton.Size = new System.Drawing.Size(303, 33);
            this.buildSieveButton.TabIndex = 3;
            this.buildSieveButton.Text = "Найти N-простых чисел";
            this.buildSieveButton.UseVisualStyleBackColor = true;
            this.buildSieveButton.Click += new System.EventHandler(this.buildSieveButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutButton.Location = new System.Drawing.Point(315, 14);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(213, 33);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "О программе";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // решетоGroupBox
            // 
            this.решетоGroupBox.Controls.Add(this.sieveDataGridView);
            this.решетоGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.решетоGroupBox.Location = new System.Drawing.Point(12, 75);
            this.решетоGroupBox.Name = "решетоGroupBox";
            this.решетоGroupBox.Size = new System.Drawing.Size(551, 363);
            this.решетоGroupBox.TabIndex = 3;
            this.решетоGroupBox.TabStop = false;
            this.решетоGroupBox.Text = "Построение решета Сундарама";
            // 
            // sieveDataGridView
            // 
            this.sieveDataGridView.AllowUserToAddRows = false;
            this.sieveDataGridView.AllowUserToDeleteRows = false;
            this.sieveDataGridView.AllowUserToResizeColumns = false;
            this.sieveDataGridView.AllowUserToResizeRows = false;
            this.sieveDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sieveDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sieveDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sieveDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sieveDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.sieveDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sieveDataGridView.ColumnHeadersHeight = 25;
            this.sieveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sieveDataGridView.ColumnHeadersVisible = false;
            this.sieveDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sieveDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.sieveDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sieveDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.sieveDataGridView.Location = new System.Drawing.Point(6, 21);
            this.sieveDataGridView.MultiSelect = false;
            this.sieveDataGridView.Name = "sieveDataGridView";
            this.sieveDataGridView.ReadOnly = true;
            this.sieveDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sieveDataGridView.RowHeadersVisible = false;
            this.sieveDataGridView.RowHeadersWidth = 50;
            this.sieveDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.sieveDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.sieveDataGridView.ShowCellErrors = false;
            this.sieveDataGridView.ShowCellToolTips = false;
            this.sieveDataGridView.ShowEditingIcon = false;
            this.sieveDataGridView.ShowRowErrors = false;
            this.sieveDataGridView.Size = new System.Drawing.Size(539, 336);
            this.sieveDataGridView.TabIndex = 0;
            this.sieveDataGridView.TabStop = false;
            this.sieveDataGridView.SelectionChanged += new System.EventHandler(this.sieveDataGridView_SelectionChanged);
            this.sieveDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sieveDataGridView_MouseDown);
            // 
            // saveSieveButton
            // 
            this.saveSieveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSieveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveSieveButton.Location = new System.Drawing.Point(569, 405);
            this.saveSieveButton.Name = "saveSieveButton";
            this.saveSieveButton.Size = new System.Drawing.Size(213, 33);
            this.saveSieveButton.TabIndex = 5;
            this.saveSieveButton.Text = "Сохранить решето";
            this.saveSieveButton.UseVisualStyleBackColor = true;
            this.saveSieveButton.Click += new System.EventHandler(this.saveSieveButton_Click);
            // 
            // инструкцияGroupBox
            // 
            this.инструкцияGroupBox.Controls.Add(this.инструкцияLabel);
            this.инструкцияGroupBox.Controls.Add(this.примечаниеLabel);
            this.инструкцияGroupBox.Controls.Add(this.инструкцияLabel4);
            this.инструкцияGroupBox.Controls.Add(this.инструкцияLabel3);
            this.инструкцияGroupBox.Controls.Add(this.инструкцияLabel2);
            this.инструкцияGroupBox.Controls.Add(this.инструкцияLabel1);
            this.инструкцияGroupBox.Location = new System.Drawing.Point(569, 75);
            this.инструкцияGroupBox.Name = "инструкцияGroupBox";
            this.инструкцияGroupBox.Size = new System.Drawing.Size(219, 324);
            this.инструкцияGroupBox.TabIndex = 6;
            this.инструкцияGroupBox.TabStop = false;
            // 
            // инструкцияLabel1
            // 
            this.инструкцияLabel1.AutoSize = true;
            this.инструкцияLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инструкцияLabel1.Location = new System.Drawing.Point(8, 71);
            this.инструкцияLabel1.Name = "инструкцияLabel1";
            this.инструкцияLabel1.Size = new System.Drawing.Size(173, 21);
            this.инструкцияLabel1.TabIndex = 0;
            this.инструкцияLabel1.Text = "1) Задайте значение N";
            // 
            // инструкцияLabel2
            // 
            this.инструкцияLabel2.AutoSize = true;
            this.инструкцияLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инструкцияLabel2.Location = new System.Drawing.Point(8, 100);
            this.инструкцияLabel2.Name = "инструкцияLabel2";
            this.инструкцияLabel2.Size = new System.Drawing.Size(163, 21);
            this.инструкцияLabel2.TabIndex = 0;
            this.инструкцияLabel2.Text = "2) Нажмите \"Найти...\"";
            // 
            // инструкцияLabel3
            // 
            this.инструкцияLabel3.AutoSize = true;
            this.инструкцияLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инструкцияLabel3.Location = new System.Drawing.Point(8, 129);
            this.инструкцияLabel3.Name = "инструкцияLabel3";
            this.инструкцияLabel3.Size = new System.Drawing.Size(169, 21);
            this.инструкцияLabel3.TabIndex = 0;
            this.инструкцияLabel3.Text = "3) Построится решето";
            // 
            // инструкцияLabel4
            // 
            this.инструкцияLabel4.AutoSize = true;
            this.инструкцияLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инструкцияLabel4.Location = new System.Drawing.Point(8, 159);
            this.инструкцияLabel4.Name = "инструкцияLabel4";
            this.инструкцияLabel4.Size = new System.Drawing.Size(195, 21);
            this.инструкцияLabel4.TabIndex = 0;
            this.инструкцияLabel4.Text = "4) Нажмите \"Сохранить...\"";
            // 
            // примечаниеLabel
            // 
            this.примечаниеLabel.AutoSize = true;
            this.примечаниеLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.примечаниеLabel.Location = new System.Drawing.Point(8, 41);
            this.примечаниеLabel.Name = "примечаниеLabel";
            this.примечаниеLabel.Size = new System.Drawing.Size(184, 17);
            this.примечаниеLabel.TabIndex = 0;
            this.примечаниеLabel.Text = "Подробнее в \"О программе\"";
            // 
            // инструкцияLabel
            // 
            this.инструкцияLabel.AutoSize = true;
            this.инструкцияLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.инструкцияLabel.Location = new System.Drawing.Point(6, 16);
            this.инструкцияLabel.Name = "инструкцияLabel";
            this.инструкцияLabel.Size = new System.Drawing.Size(119, 25);
            this.инструкцияLabel.TabIndex = 0;
            this.инструкцияLabel.Text = "Инструкция:";
            // 
            // FormSieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.инструкцияGroupBox);
            this.Controls.Add(this.saveSieveButton);
            this.Controls.Add(this.решетоGroupBox);
            this.Controls.Add(this.кнопкиНавигацииGroupBox);
            this.Controls.Add(this.вводЗначенияGroupBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormSieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решето Сундарама";
            ((System.ComponentModel.ISupportInitialize)(this.valueNumeric)).EndInit();
            this.вводЗначенияGroupBox.ResumeLayout(false);
            this.вводЗначенияGroupBox.PerformLayout();
            this.кнопкиНавигацииGroupBox.ResumeLayout(false);
            this.решетоGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sieveDataGridView)).EndInit();
            this.инструкцияGroupBox.ResumeLayout(false);
            this.инструкцияGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown valueNumeric;
        private System.Windows.Forms.GroupBox вводЗначенияGroupBox;
        private System.Windows.Forms.Label введитеNLabel;
        private System.Windows.Forms.GroupBox кнопкиНавигацииGroupBox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button buildSieveButton;
        private System.Windows.Forms.GroupBox решетоGroupBox;
        private System.Windows.Forms.DataGridView sieveDataGridView;
        private System.Windows.Forms.Button saveSieveButton;
        private System.Windows.Forms.GroupBox инструкцияGroupBox;
        private System.Windows.Forms.Label инструкцияLabel;
        private System.Windows.Forms.Label примечаниеLabel;
        private System.Windows.Forms.Label инструкцияLabel4;
        private System.Windows.Forms.Label инструкцияLabel3;
        private System.Windows.Forms.Label инструкцияLabel2;
        private System.Windows.Forms.Label инструкцияLabel1;
    }
}

