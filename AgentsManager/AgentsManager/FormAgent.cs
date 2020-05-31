using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentsManager
{
    public partial class FormAgent : Form
    {
        //Dictionary<int, string> agent = new Dictionary<int, string>();
        public Dictionary<string, Agent> allAgents;
        public int staticAgentNum;
        public FormAgent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent();

            agent.AgentName = txtName.Text;
            agent.FamilyName = txtSurName.Text;
            agent.Rating = txtRating.Text;
            agent.Id = staticAgentNum;
            agent.IndependedAgent = !txtNo.Checked;

            allAgents.Add(agent.Id.ToString(), agent);

            this.Close();
            //this.Hide();\
            //allAgents.Add(2, textBox2.Text);
            //allAgents.Add(3, textBox3.Text);
            //agent.Add(4, textBox4.Text);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
