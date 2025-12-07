namespace InterntServices
{
    partial class mainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btOverBundies = new System.Windows.Forms.Button();
            this.btMainPage = new System.Windows.Forms.Button();
            this.btTransifier = new System.Windows.Forms.Button();
            this.btBundies = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btOverBundies);
            this.panel1.Controls.Add(this.btMainPage);
            this.panel1.Controls.Add(this.btTransifier);
            this.panel1.Controls.Add(this.btBundies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 61);
            this.panel1.TabIndex = 0;
            // 
            // btOverBundies
            // 
            this.btOverBundies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btOverBundies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOverBundies.Location = new System.Drawing.Point(0, 0);
            this.btOverBundies.Name = "btOverBundies";
            this.btOverBundies.Size = new System.Drawing.Size(110, 61);
            this.btOverBundies.TabIndex = 4;
            this.btOverBundies.Text = "باقات العروض";
            this.btOverBundies.UseVisualStyleBackColor = false;
            this.btOverBundies.Click += new System.EventHandler(this.button9_Click);
            // 
            // btMainPage
            // 
            this.btMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainPage.Location = new System.Drawing.Point(298, 0);
            this.btMainPage.Name = "btMainPage";
            this.btMainPage.Size = new System.Drawing.Size(121, 58);
            this.btMainPage.TabIndex = 3;
            this.btMainPage.Text = "الصفحة الرئيسية";
            this.btMainPage.UseVisualStyleBackColor = false;
            this.btMainPage.Click += new System.EventHandler(this.btMainPage_Click);
            // 
            // btTransifier
            // 
            this.btTransifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btTransifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTransifier.Location = new System.Drawing.Point(106, 0);
            this.btTransifier.Name = "btTransifier";
            this.btTransifier.Size = new System.Drawing.Size(97, 61);
            this.btTransifier.TabIndex = 2;
            this.btTransifier.Text = "التحويل";
            this.btTransifier.UseVisualStyleBackColor = false;
            this.btTransifier.Click += new System.EventHandler(this.btTransifier_Click);
            // 
            // btBundies
            // 
            this.btBundies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBundies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBundies.Location = new System.Drawing.Point(198, 0);
            this.btBundies.Name = "btBundies";
            this.btBundies.Size = new System.Drawing.Size(105, 61);
            this.btBundies.TabIndex = 1;
            this.btBundies.Text = "الباقات";
            this.btBundies.UseVisualStyleBackColor = false;
            this.btBundies.Click += new System.EventHandler(this.btBundies_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.Controls.Add(this.dataGridView1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(419, 315);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(39F, 76F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(419, 376);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(20, 17, 20, 17);
            this.Name = "mainPage";
            this.Text = "mainPage";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btBundies;
        private System.Windows.Forms.Button btOverBundies;
        private System.Windows.Forms.Button btMainPage;
        private System.Windows.Forms.Button btTransifier;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}