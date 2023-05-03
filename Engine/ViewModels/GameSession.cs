﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    internal class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession() { 
            
            CurrentPlayer = new Player();
            CurrentPlayer.setName("Besi");
            CurrentPlayer.setGold(1000000);
        }
    }
}