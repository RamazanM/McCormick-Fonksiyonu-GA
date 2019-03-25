using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GenetikAlgoritma
{
    public partial class Main : Form
    {
        AI ai;
        bool isInitialized = false;
        public Main()
        {
            InitializeComponent();
            chart1.Titles.Add("Population");
            chart2.Titles.Add("Elites");
            startButton.Enabled = false;
            iterateBtn.Enabled = false;
        }

        private void iterateBtn_Click(object sender, EventArgs e)
        {
            ai.Iterate();
            UpdateCharts();
        }

        public void UpdateCharts()
        {
            ai.population = ai.population.OrderBy((Kromozom k) => k.Function()).ToList();

            chart1.Series.Clear();
            for (int i = 0; i < ai.population.Count; i++)
            {
                Series s = chart1.Series.Add(ai.population[i].Function().ToString());
                s.Points.Add(ai.population[i].Function());
            }

            chart2.Series.Clear();
            for (int i = 0; i < ai.elites.Count; i++)
            {
                Console.WriteLine(ai.elites[i].Function().ToString() + "-x:" + ai.elites[i].genes[0].value.ToString() + "-y:" + ai.elites[i].genes[1].value.ToString());
                Series s = chart2.Series.Add(ai.elites[i].Function().ToString());
                s.Points.Add(ai.elites[i].Function());
            }
        }

        private void initPopulation_Click(object sender, EventArgs e)
        {
            try
            {
                AI.crossoverRate = double.Parse(crossoverRateTxt.Text);
                AI.eliteCount = (int)eliteCountNUD.Value;
                AI.mutationRate = double.Parse(mutationRateTxt.Text);
                if (AI.crossoverRate < 0 || AI.crossoverRate > 1 || AI.mutationRate < 0 || AI.mutationRate > 1) throw new Exception();
            }
            catch (Exception x) { MessageBox.Show("Lütfen tüm textboxları doğru değerlerle doldurunuz.\nRate değerleri 0 ile 1 arasında olmalıdır.");return; }
            startButton.Enabled = true;
            iterateBtn.Enabled = true;
            this.ai = new AI((int)populationSizeNUD.Value);
            ai.population = ai.population.OrderBy((Kromozom k) => k.Function()).ToList();
            UpdateCharts();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < (int)iterateCountNUD.Value; i++)
            {
                ai.Iterate();
            }
            UpdateCharts();

        }
    }
}
