namespace Course
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFormula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLeftBorder = new System.Windows.Forms.TextBox();
            this.txtBoxRightBorder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAccuracy = new System.Windows.Forms.TextBox();
            this.radioBtnMax = new System.Windows.Forms.RadioButton();
            this.radioBtnMin = new System.Windows.Forms.RadioButton();
            this.btnOptimize = new System.Windows.Forms.Button();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnGraph = new System.Windows.Forms.Button();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnInputData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Формула";
            // 
            // txtBoxFormula
            // 
            this.txtBoxFormula.Location = new System.Drawing.Point(86, 10);
            this.txtBoxFormula.Name = "txtBoxFormula";
            this.txtBoxFormula.Size = new System.Drawing.Size(372, 22);
            this.txtBoxFormula.TabIndex = 1;
            this.txtBoxFormula.Text = "(6-x)^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Левая граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Правая граница";
            // 
            // txtBoxLeftBorder
            // 
            this.txtBoxLeftBorder.Location = new System.Drawing.Point(119, 48);
            this.txtBoxLeftBorder.Name = "txtBoxLeftBorder";
            this.txtBoxLeftBorder.Size = new System.Drawing.Size(100, 22);
            this.txtBoxLeftBorder.TabIndex = 4;
            // 
            // txtBoxRightBorder
            // 
            this.txtBoxRightBorder.Location = new System.Drawing.Point(358, 48);
            this.txtBoxRightBorder.Name = "txtBoxRightBorder";
            this.txtBoxRightBorder.Size = new System.Drawing.Size(100, 22);
            this.txtBoxRightBorder.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Точность";
            // 
            // txtBoxAccuracy
            // 
            this.txtBoxAccuracy.Location = new System.Drawing.Point(92, 88);
            this.txtBoxAccuracy.Name = "txtBoxAccuracy";
            this.txtBoxAccuracy.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAccuracy.TabIndex = 7;
            // 
            // radioBtnMax
            // 
            this.radioBtnMax.AutoSize = true;
            this.radioBtnMax.Checked = true;
            this.radioBtnMax.Location = new System.Drawing.Point(242, 90);
            this.radioBtnMax.Name = "radioBtnMax";
            this.radioBtnMax.Size = new System.Drawing.Size(95, 20);
            this.radioBtnMax.TabIndex = 8;
            this.radioBtnMax.TabStop = true;
            this.radioBtnMax.Text = "Максимум";
            this.radioBtnMax.UseVisualStyleBackColor = true;
            // 
            // radioBtnMin
            // 
            this.radioBtnMin.AutoSize = true;
            this.radioBtnMin.Location = new System.Drawing.Point(387, 90);
            this.radioBtnMin.Name = "radioBtnMin";
            this.radioBtnMin.Size = new System.Drawing.Size(89, 20);
            this.radioBtnMin.TabIndex = 9;
            this.radioBtnMin.Text = "Минимум";
            this.radioBtnMin.UseVisualStyleBackColor = true;
            // 
            // btnOptimize
            // 
            this.btnOptimize.Location = new System.Drawing.Point(176, 185);
            this.btnOptimize.Name = "btnOptimize";
            this.btnOptimize.Size = new System.Drawing.Size(142, 28);
            this.btnOptimize.TabIndex = 10;
            this.btnOptimize.Text = "Оптимизировать";
            this.btnOptimize.UseVisualStyleBackColor = true;
            this.btnOptimize.Click += new System.EventHandler(this.btnOptimize_Click);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(191, 144);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(180, 22);
            this.txtBoxResult.TabIndex = 12;
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(10, 185);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(150, 28);
            this.btnGraph.TabIndex = 13;
            this.btnGraph.Text = "Построить график";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click_1);
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(92, 116);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(279, 22);
            this.txtBoxPath.TabIndex = 14;
            this.txtBoxPath.Text = "result.txt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Результат оптимизации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Имя файла";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(372, 115);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(35, 23);
            this.btnOpenFileDialog.TabIndex = 16;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnInputData
            // 
            this.btnInputData.Location = new System.Drawing.Point(334, 186);
            this.btnInputData.Name = "btnInputData";
            this.btnInputData.Size = new System.Drawing.Size(165, 27);
            this.btnInputData.TabIndex = 17;
            this.btnInputData.Text = "Считать из файла";
            this.btnInputData.UseVisualStyleBackColor = true;
            this.btnInputData.Click += new System.EventHandler(this.btnInputData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 304);
            this.Controls.Add(this.btnInputData);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOptimize);
            this.Controls.Add(this.radioBtnMin);
            this.Controls.Add(this.radioBtnMax);
            this.Controls.Add(this.txtBoxAccuracy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxRightBorder);
            this.Controls.Add(this.txtBoxLeftBorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxFormula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFormula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLeftBorder;
        private System.Windows.Forms.TextBox txtBoxRightBorder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxAccuracy;
        private System.Windows.Forms.RadioButton radioBtnMax;
        private System.Windows.Forms.RadioButton radioBtnMin;
        private System.Windows.Forms.Button btnOptimize;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnInputData;
    }
}

