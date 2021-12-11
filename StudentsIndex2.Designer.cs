
namespace ProjectSpinTop
{
    partial class StudentsIndex2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.firstname,
            this.lastname,
            this.Address,
            this.phonenumber1,
            this.phonenumber2,
            this.email,
            this.birthday});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 334);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // firstname
            // 
            this.firstname.DataPropertyName = "firstname";
            this.firstname.HeaderText = "Όνομα";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.Width = 125;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "Επώνυμο";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Διεύθυνση";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.Width = 125;
            // 
            // phonenumber1
            // 
            this.phonenumber1.DataPropertyName = "phonenumber1";
            this.phonenumber1.HeaderText = "Τηλέφωνο";
            this.phonenumber1.MinimumWidth = 6;
            this.phonenumber1.Name = "phonenumber1";
            this.phonenumber1.Width = 125;
            // 
            // phonenumber2
            // 
            this.phonenumber2.DataPropertyName = "phonenumber2";
            this.phonenumber2.HeaderText = "Κινητό";
            this.phonenumber2.MinimumWidth = 6;
            this.phonenumber2.Name = "phonenumber2";
            this.phonenumber2.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Γενέθλια";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1086, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem
            // 
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.Checked = true;
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.Name = "κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem";
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.Text = "ΚΑΡΤΕΛΑ ΜΑΘΗΤΗ";
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem.Click += new System.EventHandler(this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem_Click);
            // 
            // σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem
            // 
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem.Name = "σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem";
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem.Text = "ΣΤΟΙΧΕΙΑ ΜΑΘΗΤΗ";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1,
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1,
            this.νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(209, 76);
            // 
            // κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1
            // 
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1.Name = "κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1";
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1.Text = "ΚΑΡΤΕΛΑ ΜΑΘΗΤΗ";
            this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1.Click += new System.EventHandler(this.κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1_Click);
            // 
            // σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1
            // 
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1.Name = "σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1";
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1.Text = "ΣΤΟΙΧΕΙΑ ΜΑΘΗΤΗ";
            // 
            // νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem
            // 
            this.νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem.Name = "νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem";
            this.νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem.Text = "ΝΕΑ ΚΑΡΑΧΩΡΗΣΗ";
            // 
            // StudentsIndex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 526);
            this.ContextMenuStrip = this.contextMenuStrip2;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsIndex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentsIndex2";
            this.Load += new System.EventHandler(this.StudentsIndex2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
       
        private System.Windows.Forms.ToolStripMenuItem κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem κΑΡΤΕΛΑΜΑΘΗΤΗToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem σΤΟΙΧΕΙΑΜΑΘΗΤΗToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem νΕΑΚΑΡΑΧΩΡΗΣΗToolStripMenuItem;
    }
}