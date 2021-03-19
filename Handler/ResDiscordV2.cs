 //i cant test this so you'll have to probably review this code but i just wanted to make the code base a tiny bit cleaner
 //for every discord presence update you can use the Update function
 //ill review this code some other time but if theres something wrong its probably an easy fix
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
    public static class DiscordV2
    {
        public static DiscordRpcClient client;
        
        public static void Start() 
        {
            client = new DiscordRpcClient("807823502379057162");
            client.Initialize();
            //check if the game is started or not
            if (isrunning)
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
            else 
            {
                if (!client.IsInitialized)
                {
                    client.Initialize();
                }
                client.SetPresence(new RichPresence()
                {
                    Details = $"Game is not running",
                    State = $"Idle",
                    Assets = new Assets()
                    {
                        LargeImageKey = "mainimage",
                        LargeImageText = "Resident Evil 2 Remake",
                    }
                });
            }
        }
        
        public static void Update()
        {
            if (isrunning)
            {
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
            if (leon)
			{
				client.SetPresence(new RichPresence()
                {
                    Details = $"Playing as Leon",
                    State = $"Exploring raccon city as Leon",
                    Assets = new Assets()
                    {
                        LargeImageKey = "mainimage",
                        LargeImageText = "Resident Evil 2 Remake",
                    }
                });
			}
			if (claire) 
			{
				client.SetPresence(new RichPresence()
                {
                    Details = $"Playing as claire,
                    State = $"Exploring raccoon city as Claire",
                    Assets = new Assets()
                    {
                        LargeImageKey = "mainimage",
                        LargeImageText = "Resident Evil 2 Remake",
                    }
                });
			}
			if (error)
			{
				client.SetPresence(new RichPresence()
                {
                    Details = $"Error",
                    State = $"Discod Presence has ran into an unknown error. Woke is a bad dev lol",
                    Assets = new Assets()
                    {
                        LargeImageKey = "mainimage",
                        LargeImageText = "Resident Evil 2 Remake",
                    }
                });
			}
        }
        
    }
}
