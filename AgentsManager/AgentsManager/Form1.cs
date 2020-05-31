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
    public partial class Form1 : Form
    {
        public Dictionary<string, Agent> allAgents = new Dictionary<string, Agent>();
        public Form1()
        {
            InitializeComponent();
            dataGridAgents.DataSource = allAgents.Values.ToList() ;
           // DataGridViewColumn dataColumnAgentName = new DataGridViewColumn();
            //dataColumnAgentName.DataPropertyName = "AgentName";
            //dataColumnAgentName.HeaderCell = new DataGridViewColumnHeaderCell();
            
           // dataGridAgents.Columns.Add(dataColumnAgentName);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAgent formAgent = new FormAgent();
            formAgent.allAgents = this.allAgents;
            formAgent.Show();
        }
    }
}
