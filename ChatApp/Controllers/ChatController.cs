using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatApp.Controllers
{
    public class ChatController : ApiController
    {
        #region Eigenschaften
        private Controller _verwalter;

        #endregion

        #region Accessoren/Modifier
        public Controller Verwalter { get => _verwalter; set => _verwalter = value; }

        #endregion

        #region Konstruktoren
        public ChatController()
        {
            this.Verwalter = new Controller();
        }
        #endregion

        #region Worker

        // GET: api/Chat
        public string Get(string wert="")
        {
            Verwalter.Nachricht_Empfangen(wert);
            return "OK";
        }

        // GET: api/Chat/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Chat
        public void Post([FromBody]string value)
        {
            
        }

        // PUT: api/Chat/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE: api/Chat/5
        public void Delete(int id)
        {

        }
        #endregion
       
    }
}
