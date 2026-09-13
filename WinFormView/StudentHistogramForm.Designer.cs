namespace WinFormView
{
    partial class StudentHistogramForm
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
            formsPlotStudents = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // formsPlotStudents
            // 
            formsPlotStudents.Location = new Point(12, 12);
            formsPlotStudents.Name = "formsPlotStudents";
            formsPlotStudents.Size = new Size(776, 426);
            formsPlotStudents.TabIndex = 0;
            // 
            // StudentHistogramForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlotStudents);
            Name = "StudentHistogramForm";
            Text = "StudentHistogramForm";
            ResumeLayout(false);
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlotStudents;
    }
}