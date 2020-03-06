using SmoBL.Controller;
using SmoBL.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoUI
{
    public partial class MainForm : Form
    {
        private QueueingSystem queueingSystem;
        private SourceController sourceController;
        private StatisticController statisticController;
        private QueueingSystemController queueSystemController;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartSimulation_Button_Click(object sender, EventArgs e)
        {
            SimulationInfo_Label.Text = "ИДЁТ СИМУЛЯЦИЯ.";
            int countChannel;
            countChannel = GetCountChannel();

            int countQueue;
            countQueue = GetCountQueue();

            float spanwDelay;
            spanwDelay = GetSpawnDelay();

            float processingTime;
            processingTime = GetProcessingTime();


            queueingSystem = new QueueingSystem(countChannel, countQueue);
            sourceController = new SourceController(true, new Source(spanwDelay));
            statisticController = new StatisticController();
            queueSystemController = new QueueingSystemController(queueingSystem,
                                                                 statisticController,
                                                                 sourceController,
                                                                 this.Statistic_RichTextBox);
            processingTime = RandomProcessingTime(processingTime * 0.75f, processingTime * 1.25f);
            queueSystemController.SystemOnlineAsync(processingTime);
        }

        private float RandomProcessingTime(double a, double b)
        {
            var rnd = new Random().NextDouble();
            return (float)(a * rnd + b * (1 - rnd));
        }

        private float GetProcessingTime()
        {
            if (float.TryParse(ProcessingTime_TextBox.Text, out float result))
            {
                return result;
            }

            ProcessingTime_TextBox.Text = 1f.ToString();
            return 1f;
        }

        private float GetSpawnDelay()
        {
            if (float.TryParse(DelayTime_TextBox.Text, out float result))
            {
                return result;
            }

            DelayTime_TextBox.Text = 1f.ToString();
            return 1f;
        }

        private int GetCountQueue()
        {
            if (int.TryParse(CountQueue_TextBox.Text, out int result))
            {
                return result;
            }

            CountQueue_TextBox.Text = 1.ToString();
            return 1;
        }

        private int GetCountChannel()
        {
            if (int.TryParse(CountChannel_TextBox.Text, out int result))
            {
                return result;
            }

            CountChannel_TextBox.Text = 1.ToString();
            return 1;
        }

        private void StopSimulation_Button_Click(object sender, EventArgs e)
        {
            sourceController.IsOnline = false;
            GetStatistic();
            SimulationInfo_Label.Text = "";
        }

        private void GetStatistic()
        {
            Statistic_RichTextBox.Invoke((Action)delegate { Statistic_RichTextBox.Text = statisticController.GetStatistic(); });
        }

    }
}
