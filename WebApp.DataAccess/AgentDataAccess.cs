using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entity;
namespace WebApp.DataAccess
{
    public class AgentDataAccess : IAgent
    {

        public List<AgentEntity> GetAgentDetails()
        {

            List<AgentEntity> lstAgentEntity = new List<AgentEntity>()
            {
                new AgentEntity{ iAgentId=1, sFirstName="Avinash", sLastName="Joshi"  },
                new AgentEntity{ iAgentId=2, sFirstName="Avi", sLastName="Vyas"  },
                new AgentEntity{ iAgentId=3, sFirstName="Rajesh", sLastName="Vox"  },
            };

            return lstAgentEntity;

        }




    }
}
