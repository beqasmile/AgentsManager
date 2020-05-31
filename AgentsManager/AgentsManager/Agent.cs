using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AgentsManager
{
    public class Agent
    {
        private int id;
        private string agentName;
        private string familyName;
        private string rating;
        private bool independedAgent;

        public int Id { get => id; set => id = value; }
        public string AgentName { get => agentName; set => agentName = value; }
        public string FamilyName { get => familyName; set => familyName = value; }
        public string Rating { get => rating; set => rating = value; }
        public bool IndependedAgent { get => independedAgent; set => independedAgent = value; }
    }
}
