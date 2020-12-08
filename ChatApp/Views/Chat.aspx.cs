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
            ListBox1.Items.Clear();
            for (int index = 0; index < Verwalter.ChatList.Count; index++)
            {
                if (Verwalter.ChatList[index].Status == "versand")
                {
                    ListBox1.Items.Add("Versendet:");
                    ListBox1.Items.Add(Verwalter.ChatList[index].Datum.ToString() + ": " + Verwalter.ChatList[index].Text);
                    ListBox1.Items.Add("");

                }
                else
                {
                    ListBox1.Items.Add("Empfangen:");
                    ListBox1.Items.Add(Verwalter.ChatList[index].Datum.ToString() + ": " + Verwalter.ChatList[index].Text);
                    ListBox1.Items.Add("");
                }
            }
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
            
            
           
        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            Verwalter.Senden(urltxt.Text, chattxt.Text);
            Response.Redirect("Chat.aspx");
            

            
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {

        }
        #endregion

     
    }
}