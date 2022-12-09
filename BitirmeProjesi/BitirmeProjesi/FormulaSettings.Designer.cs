
namespace BitirmeProjesi
{
    partial class FormulaSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormulaSettings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FormulaName = new System.Windows.Forms.TextBox();
            this.FormulaAddBtn = new System.Windows.Forms.Button();
            this.FormulaDeleteBtn = new System.Windows.Forms.Button();
            this.FormulaUpdateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.BrowseText = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.FormulaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FormulTypeText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ThinnerText = new System.Windows.Forms.TextBox();
            this.PaintNameText = new System.Windows.Forms.TextBox();
            this.HardenerText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AText = new System.Windows.Forms.MaskedTextBox();
            this.BText = new System.Windows.Forms.MaskedTextBox();
            this.CText = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PaintQrText = new System.Windows.Forms.TextBox();
            this.HardenerQrText = new System.Windows.Forms.TextBox();
            this.ThinnerQrText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormulaName
            // 
            this.FormulaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaName.Location = new System.Drawing.Point(12, 495);
            this.FormulaName.MaxLength = 60;
            this.FormulaName.Name = "FormulaName";
            this.FormulaName.Size = new System.Drawing.Size(188, 32);
            this.FormulaName.TabIndex = 2;
            this.FormulaName.Validating += new System.ComponentModel.CancelEventHandler(this.FormulaName_Validating);
            // 
            // FormulaAddBtn
            // 
            this.FormulaAddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaAddBtn.Location = new System.Drawing.Point(699, 417);
            this.FormulaAddBtn.Name = "FormulaAddBtn";
            this.FormulaAddBtn.Size = new System.Drawing.Size(143, 49);
            this.FormulaAddBtn.TabIndex = 6;
            this.FormulaAddBtn.Text = "Formül Ekle";
            this.FormulaAddBtn.UseVisualStyleBackColor = true;
            this.FormulaAddBtn.Click += new System.EventHandler(this.FormulaAddBtn_Click);
            // 
            // FormulaDeleteBtn
            // 
            this.FormulaDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaDeleteBtn.Location = new System.Drawing.Point(699, 472);
            this.FormulaDeleteBtn.Name = "FormulaDeleteBtn";
            this.FormulaDeleteBtn.Size = new System.Drawing.Size(143, 49);
            this.FormulaDeleteBtn.TabIndex = 7;
            this.FormulaDeleteBtn.Text = "Formül Sil";
            this.FormulaDeleteBtn.UseVisualStyleBackColor = true;
            this.FormulaDeleteBtn.Click += new System.EventHandler(this.FormulaDeleteBtn_Click);
            // 
            // FormulaUpdateBtn
            // 
            this.FormulaUpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaUpdateBtn.Location = new System.Drawing.Point(699, 527);
            this.FormulaUpdateBtn.Name = "FormulaUpdateBtn";
            this.FormulaUpdateBtn.Size = new System.Drawing.Size(143, 49);
            this.FormulaUpdateBtn.TabIndex = 8;
            this.FormulaUpdateBtn.Text = "Formül Güncelle";
            this.FormulaUpdateBtn.UseVisualStyleBackColor = true;
            this.FormulaUpdateBtn.Click += new System.EventHandler(this.FormulaUpdateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Formül Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(207, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Boya";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(207, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sertleştirici";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(207, 530);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tiner";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBtn.Location = new System.Drawing.Point(765, 17);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(77, 32);
            this.SearchBtn.TabIndex = 16;
            this.SearchBtn.Text = "Ara";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BrowseText
            // 
            this.BrowseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrowseText.Location = new System.Drawing.Point(107, 16);
            this.BrowseText.MaxLength = 60;
            this.BrowseText.Name = "BrowseText";
            this.BrowseText.Size = new System.Drawing.Size(652, 32);
            this.BrowseText.TabIndex = 17;
            // 
            // FormulaID
            // 
            this.FormulaID.Enabled = false;
            this.FormulaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaID.Location = new System.Drawing.Point(12, 437);
            this.FormulaID.MaxLength = 5;
            this.FormulaID.Name = "FormulaID";
            this.FormulaID.Size = new System.Drawing.Size(188, 32);
            this.FormulaID.TabIndex = 1;
            this.FormulaID.Validating += new System.ComponentModel.CancelEventHandler(this.FormulaID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Formül id";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormulTypeText
            // 
            this.FormulTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulTypeText.Location = new System.Drawing.Point(12, 553);
            this.FormulTypeText.MaxLength = 10;
            this.FormulTypeText.Name = "FormulTypeText";
            this.FormulTypeText.Size = new System.Drawing.Size(188, 32);
            this.FormulTypeText.TabIndex = 21;
            this.FormulTypeText.Validating += new System.ComponentModel.CancelEventHandler(this.FormulTypeText_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 530);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Formül Tipi";
            // 
            // ThinnerText
            // 
            this.ThinnerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThinnerText.Location = new System.Drawing.Point(303, 553);
            this.ThinnerText.MaxLength = 100;
            this.ThinnerText.Name = "ThinnerText";
            this.ThinnerText.Size = new System.Drawing.Size(165, 32);
            this.ThinnerText.TabIndex = 23;
            this.ThinnerText.Validating += new System.ComponentModel.CancelEventHandler(this.ThinnerText_Validating);
            // 
            // PaintNameText
            // 
            this.PaintNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaintNameText.Location = new System.Drawing.Point(303, 437);
            this.PaintNameText.MaxLength = 100;
            this.PaintNameText.Name = "PaintNameText";
            this.PaintNameText.Size = new System.Drawing.Size(165, 32);
            this.PaintNameText.TabIndex = 23;
            this.PaintNameText.Validating += new System.ComponentModel.CancelEventHandler(this.PaintNameText_Validating);
            // 
            // HardenerText
            // 
            this.HardenerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HardenerText.Location = new System.Drawing.Point(303, 495);
            this.HardenerText.MaxLength = 100;
            this.HardenerText.Name = "HardenerText";
            this.HardenerText.Size = new System.Drawing.Size(165, 32);
            this.HardenerText.TabIndex = 24;
            this.HardenerText.Validating += new System.ComponentModel.CancelEventHandler(this.HardenerText_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(299, 417);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Boya Adı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(299, 472);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Sertleştirici Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(299, 530);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tiner Adı";
            // 
            // AText
            // 
            this.AText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AText.Location = new System.Drawing.Point(210, 437);
            this.AText.Mask = "%00.00";
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(83, 32);
            this.AText.TabIndex = 28;
            this.AText.Validating += new System.ComponentModel.CancelEventHandler(this.AText_Validating);
            // 
            // BText
            // 
            this.BText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BText.Location = new System.Drawing.Point(210, 495);
            this.BText.Mask = "%00.00";
            this.BText.Name = "BText";
            this.BText.Size = new System.Drawing.Size(83, 32);
            this.BText.TabIndex = 30;
            this.BText.Validating += new System.ComponentModel.CancelEventHandler(this.BText_Validating);
            // 
            // CText
            // 
            this.CText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CText.Location = new System.Drawing.Point(210, 553);
            this.CText.Mask = "%00.00";
            this.CText.Name = "CText";
            this.CText.Size = new System.Drawing.Size(83, 32);
            this.CText.TabIndex = 31;
            this.CText.Validating += new System.ComponentModel.CancelEventHandler(this.CText_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Formül Adı";
            // 
            // PaintQrText
            // 
            this.PaintQrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaintQrText.Location = new System.Drawing.Point(480, 436);
            this.PaintQrText.MaxLength = 7;
            this.PaintQrText.Name = "PaintQrText";
            this.PaintQrText.Size = new System.Drawing.Size(165, 32);
            this.PaintQrText.TabIndex = 34;
            this.PaintQrText.Validating += new System.ComponentModel.CancelEventHandler(this.PaintQrText_Validating);
            // 
            // HardenerQrText
            // 
            this.HardenerQrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HardenerQrText.Location = new System.Drawing.Point(480, 494);
            this.HardenerQrText.MaxLength = 7;
            this.HardenerQrText.Name = "HardenerQrText";
            this.HardenerQrText.Size = new System.Drawing.Size(165, 32);
            this.HardenerQrText.TabIndex = 35;
            this.HardenerQrText.Validating += new System.ComponentModel.CancelEventHandler(this.HardenerQrText_Validating);
            // 
            // ThinnerQrText
            // 
            this.ThinnerQrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ThinnerQrText.Location = new System.Drawing.Point(480, 552);
            this.ThinnerQrText.MaxLength = 7;
            this.ThinnerQrText.Name = "ThinnerQrText";
            this.ThinnerQrText.Size = new System.Drawing.Size(165, 32);
            this.ThinnerQrText.TabIndex = 36;
            this.ThinnerQrText.Validating += new System.ComponentModel.CancelEventHandler(this.ThinnerQrText_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(476, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Boya Qr Kod";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(476, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Sertleştirici Qr Kod";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(476, 530);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Tiner Qr Kod";
            // 
            // FormulaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(857, 679);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ThinnerQrText);
            this.Controls.Add(this.HardenerQrText);
            this.Controls.Add(this.PaintQrText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CText);
            this.Controls.Add(this.BText);
            this.Controls.Add(this.AText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.HardenerText);
            this.Controls.Add(this.PaintNameText);
            this.Controls.Add(this.ThinnerText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FormulTypeText);
            this.Controls.Add(this.BrowseText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormulaUpdateBtn);
            this.Controls.Add(this.FormulaDeleteBtn);
            this.Controls.Add(this.FormulaAddBtn);
            this.Controls.Add(this.FormulaName);
            this.Controls.Add(this.FormulaID);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormulaSettings";
            this.Text = "FormulAyarlari";
            this.Load += new System.EventHandler(this.FormulaSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox FormulaName;
        private System.Windows.Forms.Button FormulaAddBtn;
        private System.Windows.Forms.Button FormulaDeleteBtn;
        private System.Windows.Forms.Button FormulaUpdateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox BrowseText;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox FormulaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox HardenerText;
        private System.Windows.Forms.TextBox PaintNameText;
        private System.Windows.Forms.TextBox ThinnerText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FormulTypeText;
        private System.Windows.Forms.MaskedTextBox AText;
        private System.Windows.Forms.MaskedTextBox CText;
        private System.Windows.Forms.MaskedTextBox BText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ThinnerQrText;
        private System.Windows.Forms.TextBox HardenerQrText;
        private System.Windows.Forms.TextBox PaintQrText;
    }
}