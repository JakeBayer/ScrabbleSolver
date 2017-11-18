using System.Windows.Forms;

namespace ScrabbleWordFinder
{
    partial class FrmScrabble
    {
        private const int MATCHBYPOS_SIZE = 30;
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
            this.lblRack = new System.Windows.Forms.Label();
            this.lblLetterLimit = new System.Windows.Forms.Label();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.btnFindWords_Rack = new System.Windows.Forms.Button();
            this.lblBoard = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblAnywhere = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtAnywhere = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnFindWords_Board = new System.Windows.Forms.Button();
            this.lblPostition = new System.Windows.Forms.Label();
            this.btnFindWords_Position = new System.Windows.Forms.Button();
            this.rtbGeneratedWords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblRack
            // 
            this.lblRack.AutoSize = true;
            this.lblRack.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRack.Location = new System.Drawing.Point(3, 3);
            this.lblRack.Name = "lblRack";
            this.lblRack.Size = new System.Drawing.Size(71, 30);
            this.lblRack.TabIndex = 0;
            this.lblRack.Text = "Rack";
            // 
            // lblLetterLimit
            // 
            this.lblLetterLimit.AutoSize = true;
            this.lblLetterLimit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetterLimit.Location = new System.Drawing.Point(65, 8);
            this.lblLetterLimit.Name = "lblLetterLimit";
            this.lblLetterLimit.Size = new System.Drawing.Size(316, 22);
            this.lblLetterLimit.TabIndex = 1;
            this.lblLetterLimit.Text = " (up to 12 letters, use \'*\' for wildcard)";
            // 
            // txtRack
            // 
            this.txtRack.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRack.Location = new System.Drawing.Point(8, 36);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(635, 20);
            this.txtRack.TabIndex = 2;
            // 
            // btnFindWords_Rack
            // 
            this.btnFindWords_Rack.Location = new System.Drawing.Point(649, 36);
            this.btnFindWords_Rack.Name = "btnFindWords_Rack";
            this.btnFindWords_Rack.Size = new System.Drawing.Size(93, 20);
            this.btnFindWords_Rack.TabIndex = 3;
            this.btnFindWords_Rack.Text = "Find Words";
            this.btnFindWords_Rack.UseVisualStyleBackColor = true;
            this.btnFindWords_Rack.Click += new System.EventHandler(this.btnFindWords_Rack_Click);
            // 
            // lblBoard
            // 
            this.lblBoard.AutoSize = true;
            this.lblBoard.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoard.Location = new System.Drawing.Point(3, 74);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(80, 30);
            this.lblBoard.TabIndex = 4;
            this.lblBoard.Text = "Board";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 104);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(42, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "At Start";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(426, 104);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(39, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "At End";
            // 
            // lblAnywhere
            // 
            this.lblAnywhere.AutoSize = true;
            this.lblAnywhere.Location = new System.Drawing.Point(221, 104);
            this.lblAnywhere.Name = "lblAnywhere";
            this.lblAnywhere.Size = new System.Drawing.Size(54, 13);
            this.lblAnywhere.TabIndex = 7;
            this.lblAnywhere.Text = "Anywhere";
            // 
            // txtStart
            // 
            this.txtStart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStart.Location = new System.Drawing.Point(8, 120);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(210, 20);
            this.txtStart.TabIndex = 8;
            // 
            // txtAnywhere
            // 
            this.txtAnywhere.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnywhere.Location = new System.Drawing.Point(224, 120);
            this.txtAnywhere.Name = "txtAnywhere";
            this.txtAnywhere.Size = new System.Drawing.Size(199, 20);
            this.txtAnywhere.TabIndex = 9;
            // 
            // txtEnd
            // 
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.Location = new System.Drawing.Point(429, 120);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(214, 20);
            this.txtEnd.TabIndex = 10;
            // 
            // btnFindWords_Board
            // 
            this.btnFindWords_Board.Location = new System.Drawing.Point(649, 120);
            this.btnFindWords_Board.Name = "btnFindWords_Board";
            this.btnFindWords_Board.Size = new System.Drawing.Size(93, 20);
            this.btnFindWords_Board.TabIndex = 11;
            this.btnFindWords_Board.Text = "Find Words";
            this.btnFindWords_Board.UseVisualStyleBackColor = true;
            // 
            // lblPostition
            // 
            this.lblPostition.AutoSize = true;
            this.lblPostition.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostition.Location = new System.Drawing.Point(3, 163);
            this.lblPostition.Name = "lblPostition";
            this.lblPostition.Size = new System.Drawing.Size(220, 30);
            this.lblPostition.TabIndex = 12;
            this.lblPostition.Text = "Match By Position";
            // 
            // btnFindWords_Position
            // 
            this.btnFindWords_Position.Location = new System.Drawing.Point(649, 189);
            this.btnFindWords_Position.Name = "btnFindWords_Position";
            this.btnFindWords_Position.Size = new System.Drawing.Size(93, 20);
            this.btnFindWords_Position.TabIndex = 13;
            this.btnFindWords_Position.Text = "Find Words";
            this.btnFindWords_Position.UseVisualStyleBackColor = true;
            // 
            // rtbGeneratedWords
            // 
            this.rtbGeneratedWords.Location = new System.Drawing.Point(3, 252);
            this.rtbGeneratedWords.Name = "rtbGeneratedWords";
            this.rtbGeneratedWords.Size = new System.Drawing.Size(739, 333);
            this.rtbGeneratedWords.TabIndex = 14;
            this.rtbGeneratedWords.Text = "";
            // 
            // FrmScrabble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 626);
            this.Controls.Add(this.rtbGeneratedWords);
            this.Controls.Add(this.btnFindWords_Position);
            this.Controls.Add(this.lblPostition);
            this.Controls.Add(this.btnFindWords_Board);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtAnywhere);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblAnywhere);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblBoard);
            this.Controls.Add(this.btnFindWords_Rack);
            this.Controls.Add(this.txtRack);
            this.Controls.Add(this.lblLetterLimit);
            this.Controls.Add(this.lblRack);
            this.Name = "FrmScrabble";
            this.Text = "frmScrabble";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InitializeMatchByPosition()
        {
            this.txtMatchByPosition = new System.Windows.Forms.TextBox[12];
            this.lblMatchByPosition = new System.Windows.Forms.Label[12];
            for (int i = 0; i < 12; i++)
            {
                int j = i;
                this.txtMatchByPosition[i] = new System.Windows.Forms.TextBox();
                this.txtMatchByPosition[i].CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
                this.txtMatchByPosition[i].Location = new System.Drawing.Point(10 + i * MATCHBYPOS_SIZE, 193);
                this.txtMatchByPosition[i].Size = new System.Drawing.Size(MATCHBYPOS_SIZE, MATCHBYPOS_SIZE);
                this.txtMatchByPosition[i].Font = new System.Drawing.Font("Arial Black", 12F);
                this.txtMatchByPosition[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                this.txtMatchByPosition[i].TabIndex = 13 + i;
                this.txtMatchByPosition[i].MaxLength = 1;
                this.txtMatchByPosition[i].KeyDown += (sender, e) => txtPosistion_KeyDown(sender, e, j);
                this.txtMatchByPosition[i].KeyUp += (sender, e) => txtPosistion_KeyUp(sender, e, j);
                this.txtMatchByPosition[i].Name = i.ToString();

                this.lblMatchByPosition[i] = new System.Windows.Forms.Label();
                this.lblMatchByPosition[i].AutoSize = false;
                this.lblMatchByPosition[i].Location = new System.Drawing.Point(10 + i * MATCHBYPOS_SIZE, 218);
                this.lblMatchByPosition[i].Name = "lblPos" + i.ToString();
                this.lblMatchByPosition[i].Size = new System.Drawing.Size(MATCHBYPOS_SIZE, MATCHBYPOS_SIZE);
                this.lblMatchByPosition[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.lblMatchByPosition[i].Text = (i + 1).ToString();
              
                this.Controls.Add(txtMatchByPosition[i]);
                this.Controls.Add(lblMatchByPosition[i]);
            }

            this.rtbGeneratedWords.Size = new System.Drawing.Size(739, Screen.GetWorkingArea(this).Height - 300);
        }

        #endregion

        private System.Windows.Forms.Label lblRack;
        private System.Windows.Forms.Label lblLetterLimit;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.Button btnFindWords_Rack;
        private System.Windows.Forms.Label lblBoard;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblAnywhere;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtAnywhere;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnFindWords_Board;
        private System.Windows.Forms.Label lblPostition;
        private System.Windows.Forms.TextBox[] txtMatchByPosition;
        private System.Windows.Forms.Label[] lblMatchByPosition;
        private System.Windows.Forms.Button btnFindWords_Position;
        private System.Windows.Forms.RichTextBox rtbGeneratedWords;
    }
}

