using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resident_Evil_2_RPC.Handler;
using static Resident_Evil_2_RPC.Handler.Discord;
using static Resident_Evil_2_RPC.Handler.ResidentEvil;

namespace Resident_Evil_2_RPC
{
    public partial class RPC : Form
    {
        public static bool leon = false;
        public static bool claire = false;
        public static bool discordstarted = false;
        public static bool isrunning;
        public static bool error;

        public RPC()
        {
            InitializeComponent();
            Discord.ID();
            ResidentEvil.Check();
            statusLabel.Text = "Checking game status";
            if (isrunning == true)
            {
                Discord.Start();
                statusLabel.Text = "Game is running";
            }
            if (isrunning == false)
            {
                Discord.StartNotRunning();
                statusLabel.Text = "Game is not running";
            }
        }

        private void leonBtn_Click(object sender, EventArgs e)
        {
            characterLabel.Text = "Leon";
            if (discordstarted == false)
            {
                claire = false;
                leon = true;
                Discord.LeonStart();
                discordstarted = true;
            }
            else
            {
                claire = false;
                leon = true;
                Discord.Leon();
                discordstarted = true;
            }
        }

        private void claireBtn_Click(object sender, EventArgs e)
        {
            characterLabel.Text = "Claire";
            if (discordstarted == false)
            {
                claire = true;
                leon = false;
                Discord.ClaireStart();
                discordstarted = true;
            }
            else
            {
                claire = true;
                leon = false;
                Discord.Claire();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Discord.Dispose();
        }

        private void afkBtn_Click(object sender, EventArgs e)
        {
            Discord.AFK();
        }

        private void checkGameBtn_Click(object sender, EventArgs e)
        {
            ResidentEvil.Check();
            statusLabel.Text = "Checking game status";
            if (isrunning == true)
            {
                Discord.Running();
                statusLabel.Text = "Game is running";
            }
            if (isrunning == false)
            {
                Discord.NotRunning();
                statusLabel.Text = "Game is not running";
            }
            else
            {
                Discord.Error();
                statusLabel.Text = "Unknown error";
            }
        }
    }
}
