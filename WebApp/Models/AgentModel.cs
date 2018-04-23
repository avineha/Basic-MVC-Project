using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Entity;
using WebApp.BusinessModel;
namespace WebApp.Models
{
    public class AgentModel
    {
        public List<AgentEntity> LoadAgentData()
        {
            AgentBusinessModel agentBusinessModel = new AgentBusinessModel();
            return agentBusinessModel.LoadAgentData();

        }




    }
}