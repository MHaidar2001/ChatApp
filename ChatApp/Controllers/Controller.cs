using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using ChatApp.Models;

namespace ChatApp.Controllers
{
    public class Controller
    {
        #region Eigenschaften
        private List<Models.Nachricht> _ChatList;

        #endregion

        #region Accessoren/Modifier
        public List<Nachricht> ChatList { get => _ChatList; set => _ChatList = value; }

        #endregion

        #region Konstruktoren
        public Controller()
        {

           this.ChatList = new List<Nachricht>();
        }


        #endregion

        #region Worker
        public async Task Senden(string url, string Nachricht)
        {
            HttpClient ht = new HttpClient();

            var x = ht.GetAsync(url + "?wert=" + Nachricht).Result;

            Models.Nachricht N1 = new Nachricht(ChatList.Count , Nachricht, DateTime.Now, "versand");
            ChatList.Add(N1);

        }

        public void Nachricht_Empfangen(string wert)
        {
            
           
                Models.Nachricht N2 = new Nachricht(ChatList.Count, wert, DateTime.Now, "empfang");
               ChatList.Add(N2);
            
           
        }
        #endregion
    }
}