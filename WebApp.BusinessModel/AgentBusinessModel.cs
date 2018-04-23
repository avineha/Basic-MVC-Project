using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.DataAccess;
using WebApp.Entity;
namespace WebApp.BusinessModel
{
    public class AgentBusinessModel
    {

        public List<AgentEntity> LoadAgentData()
        {
            IAgent agent = new AgentDataAccess();
            return agent.GetAgentDetails();

        }
    }
}
