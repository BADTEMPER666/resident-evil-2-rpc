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

namespace Resident_Evil_2_RPC
{
    public partial class RPC : Form
    {
        public static bool leon = false;
        public static bool claire = false;
        public static bool discordstarted = false;

        public RPC()
        {
            InitializeComponent();
            Discord.ID();
            Discord.Start();
        }

        private void leonBtn_Click(object sender, EventArgs e)
        {
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
    }
}
