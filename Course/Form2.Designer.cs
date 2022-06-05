namespace Course
{
    partial class Form2
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.radioBntShowLegend = new System.Windows.Forms.RadioButton();
            this.radioBtbOffLegend = new System.Windows.Forms.RadioButton();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(275, 0);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(682, 525);
            this.zedGraph.TabIndex = 0;
            // 
            // radioBntShowLegend
            // 
            this.radioBntShowLegend.AutoSize = true;
            this.radioBntShowLegend.Checked = true;
            this.radioBntShowLegend.Location = new System.Drawing.Point(28, 21);
            this.radioBntShowLegend.Name = "radioBntShowLegend";
            this.radioBntShowLegend.Size = new System.Drawing.Size(149, 20);
            this.radioBntShowLegend.TabIndex = 1;
            this.radioBntShowLegend.TabStop = true;
            this.radioBntShowLegend.Text = "Включить легенду";
            this.radioBntShowLegend.UseVisualStyleBackColor = true;
            this.radioBntShowLegend.CheckedChanged += new System.EventHandler(this.radioBntShowLegend_CheckedChanged);
            // 
            // radioBtbOffLegend
            // 
            this.radioBtbOffLegend.AutoSize = true;
            this.radioBtbOffLegend.Location = new System.Drawing.Point(28, 47);
            this.radioBtbOffLegend.Name = "radioBtbOffLegend";
            this.radioBtbOffLegend.Size = new System.Drawing.Size(158, 20);
            this.radioBtbOffLegend.TabIndex = 2;
            this.radioBtbOffLegend.Text = "Выключить легенду";
            this.radioBtbOffLegend.UseVisualStyleBackColor = true;
            this.radioBtbOffLegend.CheckedChanged += new System.EventHandler(this.radioBtbOffLegend_CheckedChanged);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(28, 87);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(149, 23);
            this.btnBold.TabIndex = 4;
            this.btnBold.Text = "Жирный шрифт";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(28, 116);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(149, 23);
            this.btnItalic.TabIndex = 5;
            this.btnItalic.Text = "Курсив";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(28, 145);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(149, 23);
            this.btnUnderline.TabIndex = 6;
            this.btnUnderline.Text = "Подчеркнутый";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 524);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.radioBtbOffLegend);
            this.Controls.Add(this.radioBntShowLegend);
            this.Controls.Add(this.zedGraph);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.RadioButton radioBntShowLegend;
        private System.Windows.Forms.RadioButton radioBtbOffLegend;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
    }
}