using System;
using Renci.SshNet;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace TestReindexSSH
{
    class SSH
    {
        //Begin Variabels
        public static SshClient client;
        //end variabels

        public static string connect(string host, int port, string username, string password)
        {
            try
            {
                client = new SshClient(host, port, username, password);
                client.Connect();
                return null; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrent wrong while disconnecting to your SSH server:" + ex.ToString()); //Return error);
                return null;
            }
        }

     public static string disconnect()
     {
         try
         {
             client.Disconnect(); //verbreekt verbinding met de SSH client
             client.Dispose(); //haalt alle instellingen van de client weg
             return null; //returned geen errors
         }
         catch(Exception Ex)
         {
             return "er is iets fout gegaan tijdens het verbreken van de verbinding met je SSH server: " + Ex.ToString(); //return error
         }
     }
    }
}
