
namespace BitirmeProjesi
{
    partial class StuffSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuffSettings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StuffNoText = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.StuffNameText = new System.Windows.Forms.TextBox();
            this.StuffLNameText = new System.Windows.Forms.TextBox();
            this.AdminChck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.BrowseText = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(968, 439);
            this.dataGridView1.TabIndex = 0;
            // 
            // StuffNoText
            // 
            this.StuffNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StuffNoText.Location = new System.Drawing.Point(15, 542);
            this.StuffNoText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StuffNoText.MaxLength = 12;
            this.StuffNoText.Name = "StuffNoText";
            this.StuffNoText.Size = new System.Drawing.Size(488, 32);
            this.StuffNoText.TabIndex = 1;
            this.StuffNoText.Validating += new System.ComponentModel.CancelEventHandler(this.StuffNoText_Validating);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddBtn.Location = new System.Drawing.Point(772, 513);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(210, 68);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Personel Ekle";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DeleteBtn.Location = new System.Drawing.Point(772, 588);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(210, 68);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Personel Sil";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UpdateBtn.Location = new System.Drawing.Point(772, 663);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(210, 65);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Personel Güncelle";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // StuffNameText
            // 
            this.StuffNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StuffNameText.Location = new System.Drawing.Point(15, 613);
            this.StuffNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StuffNameText.MaxLength = 40;
            this.StuffNameText.Name = "StuffNameText";
            this.StuffNameText.Size = new System.Drawing.Size(488, 32);
            this.StuffNameText.TabIndex = 6;
            this.StuffNameText.Validating += new System.ComponentModel.CancelEventHandler(this.StuffNameText_Validating);
            // 
            // StuffLNameText
            // 
            this.StuffLNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StuffLNameText.Location = new System.Drawing.Point(15, 684);
            this.StuffLNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StuffLNameText.MaxLength = 40;
            this.StuffLNameText.Name = "StuffLNameText";
            this.StuffLNameText.Size = new System.Drawing.Size(488, 32);
            this.StuffLNameText.TabIndex = 7;
            this.StuffLNameText.Validating += new System.ComponentModel.CancelEventHandler(this.StuffLNameText_Validating);
            // 
            // AdminChck
            // 
            this.AdminChck.AutoSize = true;
            this.AdminChck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminChck.Location = new System.Drawing.Point(15, 756);
            this.AdminChck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminChck.Name = "AdminChck";
            this.AdminChck.Size = new System.Drawing.Size(90, 23);
            this.AdminChck.TabIndex = 8;
            this.AdminChck.Text = "Yönetici";
            this.AdminChck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Personel Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Personel Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Personel Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 727);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yetki Durumu";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBtn.Location = new System.Drawing.Point(891, 20);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 39);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Ara";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // BrowseText
            // 
            this.BrowseText.BackColor = System.Drawing.SystemColors.Window;
            this.BrowseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrowseText.Location = new System.Drawing.Point(118, 20);
            this.BrowseText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrowseText.MaxLength = 12;
            this.BrowseText.Name = "BrowseText";
            this.BrowseText.Size = new System.Drawing.Size(766, 32);
            this.BrowseText.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kullanıcı ID";
            // 
            // StuffSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 749);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BrowseText);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminChck);
            this.Controls.Add(this.StuffLNameText);
            this.Controls.Add(this.StuffNameText);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.StuffNoText);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StuffSettings";
            this.Text = "PersonelAyarlari";
            this.Load += new System.EventHandler(this.StuffSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox StuffNoText;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox StuffNameText;
        private System.Windows.Forms.TextBox StuffLNameText;
        private System.Windows.Forms.CheckBox AdminChck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox BrowseText;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
    }
}