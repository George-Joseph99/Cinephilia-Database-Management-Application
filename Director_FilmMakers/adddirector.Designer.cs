
namespace DBapplication.Director_FilmMakers
{
    partial class adddirector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "d",
            "sf",
            "f",
            "vfev",
            "tsrb",
            "reyb",
            "trntujuyrn",
            "yb",
            "trb",
            "ty",
            "b",
            "ybtr",
            "n",
            "rtb",
            "y",
            "rbet",
            "ertb",
            "ryb",
            "ery",
            "y",
            "hb",
            "tbr"});
            this.comboBox1.Location = new System.Drawing.Point(463, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 24);
            this.comboBox1.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(56, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 52);
            this.label3.TabIndex = 116;
            this.label3.Text = "Select the movie Title";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Josefin Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(483, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(222, 52);
            this.label17.TabIndex = 115;
            this.label17.Text = "Link to movie";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DBapplication.Properties.Resources.editing;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(393, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 66);
            this.button1.TabIndex = 114;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Josefin Sans", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(237, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(566, 59);
            this.label12.TabIndex = 113;
            this.label12.Text = "Link to the movies you directed";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::DBapplication.Properties.Resources.refresh;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(809, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 66);
            this.button3.TabIndex = 118;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adddirector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Name = "adddirector";
            this.Size = new System.Drawing.Size(1079, 720);
            this.Load += new System.EventHandler(this.adddirector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}
