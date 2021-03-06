﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst.Models
{
    public enum Statuts
    {
        Open = 1, 
        Signed =2, 
        Factured = 3, 
        Work_In_Progress = 4, 
        Closed = 5
    }
   public class Project
    {
        public int ProjectId { get; set; }
        public DateTime SignatureDate{ get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectLeader{ get; set; }
        public Statuts Statut { get; set; }
        public IList<Client> Clients{ get; set; }

        public Project()
        {
            Clients = new List<Client>();
        }


    }
}
