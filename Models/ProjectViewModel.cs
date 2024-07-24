using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Models
{
    public class ProjectViewModel
    {
        public int id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFreelancer { get; private set; }
        public string ClientName { get; private set; }
        public string FreelancerName { get; set; }
        public decimal TotalCost { get; private set; }
        public List<string> Comments { get; private set; }

    }
}