namespace SQLite操作
{
    partial class Form1
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBoxAutoID = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.tBoxPW = new System.Windows.Forms.TextBox();
            this.tBoxRegion = new System.Windows.Forms.TextBox();
            this.tBoxPermission = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnOperate = new System.Windows.Forms.Button();
            this.BtnInsert2 = new System.Windows.Forms.Button();
            this.BtnInsertS2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(12, 344);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(78, 48);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "连接";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(197, 371);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(72, 23);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "更新";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(105, 344);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(78, 48);
            this.BtnSelect.TabIndex = 3;
            this.BtnSelect.Text = "查询1";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(288, 344);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(78, 48);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "删除1行";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 286);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "a123";
            // 
            // tBoxAutoID
            // 
            this.tBoxAutoID.Location = new System.Drawing.Point(24, 421);
            this.tBoxAutoID.Name = "tBoxAutoID";
            this.tBoxAutoID.Size = new System.Drawing.Size(56, 20);
            this.tBoxAutoID.TabIndex = 8;
            this.tBoxAutoID.Text = "6";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(117, 421);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(56, 20);
            this.tBoxName.TabIndex = 8;
            this.tBoxName.Text = "Anjun";
            // 
            // tBoxPW
            // 
            this.tBoxPW.Location = new System.Drawing.Point(197, 421);
            this.tBoxPW.Name = "tBoxPW";
            this.tBoxPW.Size = new System.Drawing.Size(56, 20);
            this.tBoxPW.TabIndex = 8;
            this.tBoxPW.Text = "123";
            // 
            // tBoxRegion
            // 
            this.tBoxRegion.Location = new System.Drawing.Point(310, 421);
            this.tBoxRegion.Name = "tBoxRegion";
            this.tBoxRegion.Size = new System.Drawing.Size(56, 20);
            this.tBoxRegion.TabIndex = 8;
            this.tBoxRegion.Text = "C6";
            // 
            // tBoxPermission
            // 
            this.tBoxPermission.Location = new System.Drawing.Point(433, 421);
            this.tBoxPermission.Name = "tBoxPermission";
            this.tBoxPermission.Size = new System.Drawing.Size(56, 20);
            this.tBoxPermission.TabIndex = 8;
            this.tBoxPermission.Text = "66";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AutoID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "userName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "userPasswd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "userRegion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Permissions";
            // 
            // BtnCheck
            // 
            this.BtnCheck.Location = new System.Drawing.Point(96, 454);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(70, 29);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "查询";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(12, 454);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(70, 29);
            this.BtnCreate.TabIndex = 3;
            this.BtnCreate.Text = "创建";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnOperate
            // 
            this.BtnOperate.Location = new System.Drawing.Point(180, 454);
            this.BtnOperate.Name = "BtnOperate";
            this.BtnOperate.Size = new System.Drawing.Size(70, 29);
            this.BtnOperate.TabIndex = 3;
            this.BtnOperate.Text = "操作";
            this.BtnOperate.UseVisualStyleBackColor = true;
            this.BtnOperate.Click += new System.EventHandler(this.BtnOperate_Click);
            // 
            // BtnInsert2
            // 
            this.BtnInsert2.Location = new System.Drawing.Point(264, 454);
            this.BtnInsert2.Name = "BtnInsert2";
            this.BtnInsert2.Size = new System.Drawing.Size(70, 29);
            this.BtnInsert2.TabIndex = 3;
            this.BtnInsert2.Text = "插入";
            this.BtnInsert2.UseVisualStyleBackColor = true;
            this.BtnInsert2.Click += new System.EventHandler(this.BtnInsert2_Click);
            // 
            // BtnInsertS2
            // 
            this.BtnInsertS2.Location = new System.Drawing.Point(507, 406);
            this.BtnInsertS2.Name = "BtnInsertS2";
            this.BtnInsertS2.Size = new System.Drawing.Size(74, 35);
            this.BtnInsertS2.TabIndex = 1;
            this.BtnInsertS2.Text = "插入1行";
            this.BtnInsertS2.UseVisualStyleBackColor = true;
            this.BtnInsertS2.Click += new System.EventHandler(this.BtnInsertS2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxPermission);
            this.Controls.Add(this.tBoxRegion);
            this.Controls.Add(this.tBoxPW);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.tBoxAutoID);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert2);
            this.Controls.Add(this.BtnOperate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsertS2);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tBoxAutoID;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.TextBox tBoxPW;
        private System.Windows.Forms.TextBox tBoxRegion;
        private System.Windows.Forms.TextBox tBoxPermission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnOperate;
        private System.Windows.Forms.Button BtnInsert2;
        private System.Windows.Forms.Button BtnInsertS2;
    }
}

