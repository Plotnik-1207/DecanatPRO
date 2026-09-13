using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using ScottPlot;

namespace WinFormView
{
    public partial class StudentHistogramForm : Form
    {
        private Logic logic;
        public StudentHistogramForm(Logic logic)
        {
            InitializeComponent();

            this.logic = logic;

            LoadHistogram();
        }
        private void LoadHistogram()
        {
            Dictionary<string, int> distribution = logic.GetSpecialityDistribution();

            string[] specialities = distribution.Keys.ToArray();

            double[] values = distribution.Values.Select(x => (double)x).ToArray();

            var plot = formsPlotStudents.Plot;

            plot.Clear();

            plot.Add.Bars(values);

            plot.Axes.Bottom.SetTicks(
                Enumerable.Range(0, specialities.Length).Select(x => (double)x).ToArray(),specialities
            );

            plot.Title("Распределение студентов по специальностям");
            plot.YLabel("Количество студентов");
            plot.XLabel("Специальность");

            formsPlotStudents.Refresh();
        }
    }
}
