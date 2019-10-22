namespace CashRegister
{
    partial class textBox
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelSteak = new System.Windows.Forms.Label();
            this.labelLobster = new System.Windows.Forms.Label();
            this.labelPie = new System.Windows.Forms.Label();
            this.steakBox = new System.Windows.Forms.TextBox();
            this.lobsterBox = new System.Windows.Forms.TextBox();
            this.pieBox = new System.Windows.Forms.TextBox();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(263, 171);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(94, 23);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "Calculate Total";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelSteak
            // 
            this.labelSteak.AutoSize = true;
            this.labelSteak.ForeColor = System.Drawing.Color.White;
            this.labelSteak.Location = new System.Drawing.Point(186, 53);
            this.labelSteak.Name = "labelSteak";
            this.labelSteak.Size = new System.Drawing.Size(94, 13);
            this.labelSteak.TabIndex = 2;
            this.labelSteak.Text = "Number Of Steaks";
            // 
            // labelLobster
            // 
            this.labelLobster.AutoSize = true;
            this.labelLobster.ForeColor = System.Drawing.Color.White;
            this.labelLobster.Location = new System.Drawing.Point(186, 93);
            this.labelLobster.Name = "labelLobster";
            this.labelLobster.Size = new System.Drawing.Size(101, 13);
            this.labelLobster.TabIndex = 3;
            this.labelLobster.Text = "Number Of Lobsters";
            this.labelLobster.Click += new System.EventHandler(this.labelLobster_Click);
            // 
            // labelPie
            // 
            this.labelPie.AutoSize = true;
            this.labelPie.ForeColor = System.Drawing.Color.White;
            this.labelPie.Location = new System.Drawing.Point(186, 132);
            this.labelPie.Name = "labelPie";
            this.labelPie.Size = new System.Drawing.Size(81, 13);
            this.labelPie.TabIndex = 4;
            this.labelPie.Text = "Number Of Pies";
            this.labelPie.Click += new System.EventHandler(this.labelPie_Click);
            // 
            // steakBox
            // 
            this.steakBox.Location = new System.Drawing.Point(369, 53);
            this.steakBox.Name = "steakBox";
            this.steakBox.Size = new System.Drawing.Size(100, 20);
            this.steakBox.TabIndex = 5;
            // 
            // lobsterBox
            // 
            this.lobsterBox.Location = new System.Drawing.Point(369, 93);
            this.lobsterBox.Name = "lobsterBox";
            this.lobsterBox.Size = new System.Drawing.Size(100, 20);
            this.lobsterBox.TabIndex = 6;
            // 
            // pieBox
            // 
            this.pieBox.Location = new System.Drawing.Point(369, 132);
            this.pieBox.Name = "pieBox";
            this.pieBox.Size = new System.Drawing.Size(100, 20);
            this.pieBox.TabIndex = 7;
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(369, 292);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(53, 20);
            this.tenderedBox.TabIndex = 8;
            this.tenderedBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.ForeColor = System.Drawing.Color.White;
            this.tenderedLabel.Location = new System.Drawing.Point(186, 292);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(53, 13);
            this.tenderedLabel.TabIndex = 9;
            this.tenderedLabel.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.ForeColor = System.Drawing.Color.White;
            this.changeLabel.Location = new System.Drawing.Point(260, 344);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 13);
            this.changeLabel.TabIndex = 10;
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(263, 426);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(75, 23);
            this.receiptButton.TabIndex = 11;
            this.receiptButton.Text = "Print Recipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.BackColor = System.Drawing.Color.Red;
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalLabel.Location = new System.Drawing.Point(260, 206);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.subTotalLabel.TabIndex = 12;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Red;
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Location = new System.Drawing.Point(260, 230);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 13);
            this.taxLabel.TabIndex = 13;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Red;
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(260, 256);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 14;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(260, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(89, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Ian\'s Steakhouse";
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(394, 426);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 23);
            this.newOrderButton.TabIndex = 16;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(263, 372);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(53, 23);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.pieBox);
            this.Controls.Add(this.lobsterBox);
            this.Controls.Add(this.steakBox);
            this.Controls.Add(this.labelPie);
            this.Controls.Add(this.labelLobster);
            this.Controls.Add(this.labelSteak);
            this.Controls.Add(this.buttonCalculate);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "textBox";
            this.Load += new System.EventHandler(this.textBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSteak;
        private System.Windows.Forms.Label labelLobster;
        private System.Windows.Forms.Label labelPie;
        private System.Windows.Forms.TextBox steakBox;
        private System.Windows.Forms.TextBox lobsterBox;
        private System.Windows.Forms.TextBox pieBox;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button changeButton;

        #endregion

        //private System.Windows.Forms.Label steakBox;
        //private System.Windows.Forms.Label lobsterBox;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.TextBox textBox2;
        //private System.Windows.Forms.TextBox textBox3;
        //private System.Windows.Forms.Label House;
        //private System.Windows.Forms.Button buttonCalxulate;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Label taxLabel;
        //private System.Windows.Forms.Label totalLabel;
        //private System.Windows.Forms.Label tenderedButton;
        //private System.Windows.Forms.TextBox textBox4;
        //private System.Windows.Forms.Button receiptButton;
        //private System.Windows.Forms.Label totalBox;
        //private System.Windows.Forms.Label taxBox;
        //private System.Windows.Forms.Label totalsBox;
        //private System.Windows.Forms.Label label3;
    }
}

