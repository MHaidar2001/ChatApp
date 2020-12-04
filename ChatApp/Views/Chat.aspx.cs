using ChatApp.Controllers;
using ChatApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatApp.Views
{
    public partial class Chat : System.Web.UI.Page
    {
        #region Eigenschaften
        private Controllers.Controller _Verwalter;

        #endregion

        #region Accessoren/Modifier
        public Controller Verwalter { get => _Verwalter; set => _Verwalter = value; }

        #endregion

        #region Konstruktoren
        public Chat()
        {
            this.Verwalter = Global.Control;
        }

        #endregion

        #region Worker
        protected void Page_Load(object sender, EventArgs e)
        {

            ChatLoad();

        }

        public void ChatLoad()
        {
            
                for (int index = 0; index < Verwalter.ChatList.Count; index++)
                {
                    ListBox1.Items.Add(Verwalter.ChatList[index].Datum.ToString() + Verwalter.ChatList[index].Text);
                }
            
           
        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            Verwalter.Senden(urltxt.Text, chattxt.Text);
            Response.Redirect("Chat.aspx");


            
        }
        #endregion


    }
}