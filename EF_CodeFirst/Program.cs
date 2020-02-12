using EF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var Context = new LisamContext();

            #region Linq

            //var query = from c in Context.Projects
            //            where c.ProjectNumber.Contains("1")
            //            select c;


            ////var query = Context.Projects
            ////    .Where(c => c.ProjectLeader
            ////    .Contains("J"));


            //foreach (var result in query)
            //{
            //    Console.WriteLine(result.ProjectLeader);
            //}

            #endregion

            #region Adding simple object to the DB
            /*
               var Client = new Client
               {
                   Company_Name = "Microsoft",
                   Email = "microsoft@hotmail.com",
                   Language = "English", 
                   Number = "05048844445", 
                   City = "Poznan", 
                   Street = "Ulica Zielona",
                   ZipCode ="4545"
               };

               Context.Clients.Add(Client);
               Context.SaveChanges();
               */
            #endregion

            #region Adding object to DB with a list
            //Client Client = Context.Clients.Single(C => C.ClientId == 2);
            //Client Mate = Context.Clients.Find(2); // -> same things


            // var P = new Project
            // {
            //     Statut = (Statuts)4,
            //     ProjectNumber = "02",
            //     ProjectLeader = "Gill Bates",
            //     SignatureDate = new DateTime(2020, 02, 04)
            // };

            // P.Clients.Add(Client); // Impossible d'add le client de la DB direcement dans le corps de l'objet ...

            // Context.Projects.Add(P); // envoie du projet dans la DB avec l'id récupéré du Client
            // Context.SaveChanges(); 
            #endregion

            #region MODIFY
            //var Project = Context.Projects.Find(1);
            //Project.ProjectLeader = "Jean-François Li Causi";
            //Project.Statut = (Statuts)4;
            //Context.SaveChanges(); 
            #endregion

            #region DELETE

            //var Dude = Context.Clients.Find(2);
            //Context.Clients.Remove(Dude);
            //Context.SaveChanges();

            #endregion

            
            Console.ReadKey();
        }
    }
}
