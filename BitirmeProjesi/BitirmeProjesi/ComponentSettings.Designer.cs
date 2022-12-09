
namespace BitirmeProjesi
{
    partial class ComponentSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentSettings));
            this.MaterialNameText = new System.Windows.Forms.TextBox();
            this.MaterialidText = new System.Windows.Forms.TextBox();
            this.MaterialUpdate = new System.Windows.Forms.Button();
            this.MaterialDelete = new System.Windows.Forms.Button();
            this.MaterialAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BrowseText = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LinerCmbx = new System.Windows.Forms.ComboBox();
            this.TopCoatCmbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialNameText
            // 
            this.MaterialNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaterialNameText.Location = new System.Drawing.Point(14, 491);
            this.MaterialNameText.MaxLength = 60;
            this.MaterialNameText.Name = "MaterialNameText";
            this.MaterialNameText.Size = new System.Drawing.Size(364, 32);
            this.MaterialNameText.TabIndex = 22;
            this.MaterialNameText.Validating += new System.ComponentModel.CancelEventHandler(this.MaterialNameText_Validating);
            // 
            // MaterialidText
            // 
            this.MaterialidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaterialidText.Location = new System.Drawing.Point(14, 433);
            this.MaterialidText.MaxLength = 9;
            this.MaterialidText.Name = "MaterialidText";
            this.MaterialidText.Size = new System.Drawing.Size(364, 32);
            this.MaterialidText.TabIndex = 21;
            this.MaterialidText.Validating += new System.ComponentModel.CancelEventHandler(this.MaterialidText_Validating);
            // 
            // MaterialUpdate
            // 
            this.MaterialUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaterialUpdate.Location = new System.Drawing.Point(665, 531);
            this.MaterialUpdate.Name = "MaterialUpdate";
            this.MaterialUpdate.Size = new System.Drawing.Size(178, 53);
            this.MaterialUpdate.TabIndex = 20;
            this.MaterialUpdate.Text = "Materyal Güncelle";
            this.MaterialUpdate.UseVisualStyleBackColor = true;
            this.MaterialUpdate.Click += new System.EventHandler(this.MaterialUpdate_Click);
            // 
            // MaterialDelete
            // 
            this.MaterialDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaterialDelete.Location = new System.Drawing.Point(665, 472);
            this.MaterialDelete.Name = "MaterialDelete";
            this.MaterialDelete.Size = new System.Drawing.Size(178, 53);
            this.MaterialDelete.TabIndex = 19;
            this.MaterialDelete.Text = "Materyal Sil";
            this.MaterialDelete.UseVisualStyleBackColor = true;
            this.MaterialDelete.Click += new System.EventHandler(this.MaterialDelete_Click);
            // 
            // MaterialAdd
            // 
            this.MaterialAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaterialAdd.Location = new System.Drawing.Point(665, 413);
            this.MaterialAdd.Name = "MaterialAdd";
            this.MaterialAdd.Size = new System.Drawing.Size(178, 53);
            this.MaterialAdd.TabIndex = 18;
            this.MaterialAdd.Text = "Materyal Ekle";
            this.MaterialAdd.UseVisualStyleBackColor = true;
            this.MaterialAdd.Click += new System.EventHandler(this.MaterialAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 357);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Materyal id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Materyal Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Astar Boyası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Sonkat Boyası";
            // 
            // BrowseText
            // 
            this.BrowseText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BrowseText.Location = new System.Drawing.Point(123, 12);
            this.BrowseText.MaxLength = 60;
            this.BrowseText.Name = "BrowseText";
            this.BrowseText.Size = new System.Drawing.Size(637, 32);
            this.BrowseText.TabIndex = 30;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SearchBtn.Location = new System.Drawing.Point(766, 12);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(77, 32);
            this.SearchBtn.TabIndex = 31;
            this.SearchBtn.Text = "Ara";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LinerCmbx
            // 
            this.LinerCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LinerCmbx.FormattingEnabled = true;
            this.LinerCmbx.Location = new System.Drawing.Point(13, 549);
            this.LinerCmbx.Name = "LinerCmbx";
            this.LinerCmbx.Size = new System.Drawing.Size(365, 33);
            this.LinerCmbx.TabIndex = 32;
            this.LinerCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.LinerCmbx_Validating);
            // 
            // TopCoatCmbx
            // 
            this.TopCoatCmbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopCoatCmbx.FormattingEnabled = true;
            this.TopCoatCmbx.Location = new System.Drawing.Point(13, 613);
            this.TopCoatCmbx.Name = "TopCoatCmbx";
            this.TopCoatCmbx.Size = new System.Drawing.Size(365, 33);
            this.TopCoatCmbx.TabIndex = 33;
            this.TopCoatCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.TopCoatCmbx_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Materyal Adı";
            // 
            // ComponentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(857, 679);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TopCoatCmbx);
            this.Controls.Add(this.LinerCmbx);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BrowseText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MaterialNameText);
            this.Controls.Add(this.MaterialidText);
            this.Controls.Add(this.MaterialUpdate);
            this.Controls.Add(this.MaterialDelete);
            this.Controls.Add(this.MaterialAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComponentSettings";
            this.Text = "ComponentSettings";
            this.Load += new System.EventHandler(this.ComponentSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MaterialNameText;
        private System.Windows.Forms.TextBox MaterialidText;
        private System.Windows.Forms.Button MaterialUpdate;
        private System.Windows.Forms.Button MaterialDelete;
        private System.Windows.Forms.Button MaterialAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BrowseText;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox TopCoatCmbx;
        private System.Windows.Forms.ComboBox LinerCmbx;
        private System.Windows.Forms.Label label5;
    }
}