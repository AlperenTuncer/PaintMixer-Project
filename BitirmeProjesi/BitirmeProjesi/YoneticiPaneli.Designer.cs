
namespace BitirmeProjesi
{
    partial class YoneticiPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.StuffBtn = new System.Windows.Forms.Button();
            this.FormulaBtn = new System.Windows.Forms.Button();
            this.ComponentBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LogBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuffBtn
            // 
            this.StuffBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.StuffBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StuffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StuffBtn.FlatAppearance.BorderSize = 0;
            this.StuffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StuffBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StuffBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StuffBtn.Location = new System.Drawing.Point(0, 79);
            this.StuffBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StuffBtn.Name = "StuffBtn";
            this.StuffBtn.Size = new System.Drawing.Size(306, 71);
            this.StuffBtn.TabIndex = 0;
            this.StuffBtn.Text = "Personel Ayarları";
            this.StuffBtn.UseVisualStyleBackColor = false;
            this.StuffBtn.Click += new System.EventHandler(this.StuffBtn_Click);
            // 
            // FormulaBtn
            // 
            this.FormulaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.FormulaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormulaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormulaBtn.FlatAppearance.BorderSize = 0;
            this.FormulaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormulaBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormulaBtn.Location = new System.Drawing.Point(0, 150);
            this.FormulaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.FormulaBtn.Name = "FormulaBtn";
            this.FormulaBtn.Size = new System.Drawing.Size(306, 71);
            this.FormulaBtn.TabIndex = 1;
            this.FormulaBtn.Text = "Formül Ayarları";
            this.FormulaBtn.UseVisualStyleBackColor = false;
            this.FormulaBtn.Click += new System.EventHandler(this.FormulaBtn_Click);
            // 
            // ComponentBtn
            // 
            this.ComponentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ComponentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComponentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComponentBtn.FlatAppearance.BorderSize = 0;
            this.ComponentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComponentBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComponentBtn.Location = new System.Drawing.Point(0, 221);
            this.ComponentBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ComponentBtn.Name = "ComponentBtn";
            this.ComponentBtn.Size = new System.Drawing.Size(306, 71);
            this.ComponentBtn.TabIndex = 2;
            this.ComponentBtn.Text = "Parça Ayarları";
            this.ComponentBtn.UseVisualStyleBackColor = false;
            this.ComponentBtn.Click += new System.EventHandler(this.ComponentBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LogBtn);
            this.panel1.Controls.Add(this.ComponentBtn);
            this.panel1.Controls.Add(this.FormulaBtn);
            this.panel1.Controls.Add(this.StuffBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 885);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 75);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAİNT MİXER";
            // 
            // LogBtn
            // 
            this.LogBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.LogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogBtn.FlatAppearance.BorderSize = 0;
            this.LogBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LogBtn.Location = new System.Drawing.Point(0, 292);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(0);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(306, 71);
            this.LogBtn.TabIndex = 3;
            this.LogBtn.Text = "Log Kaydı";
            this.LogBtn.UseVisualStyleBackColor = false;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(306, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 809);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(306, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1034, 76);
            this.panel4.TabIndex = 5;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sayfa Seçiniz";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(974, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "—";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1004, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 885);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1340, 923);
            this.MinimumSize = new System.Drawing.Size(1340, 885);
            this.Name = "YoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StuffBtn;
        private System.Windows.Forms.Button FormulaBtn;
        private System.Windows.Forms.Button ComponentBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

