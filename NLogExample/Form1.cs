using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace NLogExample
{
    public partial class Form1 : Form
    {

        internal static Logger _logger;


        public Form1()
        {
            InitializeComponent();

            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(@"c:\AppInstallFolder\NLog.config", true);
            _logger = LogManager.GetCurrentClassLogger();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 2;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Debug":
                    _logger.Debug(textBox1.Text);
                    break;
                case "Trace":
                    _logger.Trace(textBox1.Text);
                    break;
                case "Info":
                    _logger.Info(textBox1.Text);
                    break;
                case "Warn":
                    _logger.Warn(textBox1.Text);
                    break;
                case "Error":
                    _logger.Error(textBox1.Text);
                    break;
                case "Fatal":
                    _logger.Fatal(textBox1.Text);
                    break;
            }



        }
    }
}
