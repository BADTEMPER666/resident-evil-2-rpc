using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Resident_Evil_2_RPC.RPC;
using DiscordRPC;
using System.Windows.Forms;

namespace Resident_Evil_2_RPC.Handler
{
    public static class Discord
    {
        public static DiscordRpcClient client;

        public static void ID()
        {
            client = new DiscordRpcClient("807823502379057162");
            client.Initialize();
        }

        public static void Start()
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = $"Game started",
                State = $"Idle",
                Assets = new Assets()
                {
                    LargeImageKey = "mainimage",
                    LargeImageText = "Resident Evil 2 Remake",
                }
            });
        }

        public static void ClaireStart()
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = $"Playing as Claire",
                State = $"Exploring Racoon City",
                Assets = new Assets()
                {
                    LargeImageKey = "claire",
                    LargeImageText = "Resident Evil 2 Remake",
                }
            });
        }

        public static void Claire()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Playing as Claire",
                State = $"Exploring Racoon City",
                Assets = new Assets()
                {
                    LargeImageKey = "claire",
                    LargeImageText = "Resident Evil 2 Remake",
                }
            });
        }

        public static void LeonStart()
        {
            if (!client.IsInitialized)
            {
                client.Initialize();
            }
            client.SetPresence(new RichPresence()
            {
                Details = $"Playing as Leon",
                State = $"Exploring Racoon City",
                Assets = new Assets()
                {
                    LargeImageKey = "leon",
                    LargeImageText = "Resident Evil 2 Remake",
                }
            });
        }

        public static void Leon()
        {
            client.SetPresence(new RichPresence()
            {
                Details = $"Playing as Leon",
                State = $"Exploring Racoon City",
                Assets = new Assets()
                {
                    LargeImageKey = "leon",
                    LargeImageText = "Resident Evil 2 Remake",
                }
            });
        }

        public static void Check()
        {
            if (discordstarted == true)
            {
                MessageBox.Show("RPC is started");
            }
            else
            {
                MessageBox.Show("RPC isnt started");
            }
        }

        public static void Dispose()
        {
            client.Dispose();
        }
    }
}
