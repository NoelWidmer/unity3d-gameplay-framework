﻿using System;

namespace GameplayFramework
{
    public class PlayerHUDManager : IDisposable
    {
        public PlayerHUDManager(bool tickEnabled = true)
        {
            TickEnabled = tickEnabled;
        }



        private bool _tickEnabled = false;
        public bool TickEnabled
        {
            get
            {
                return _tickEnabled;
            }
            set
            {
                if(value == _tickEnabled)
                    return;

                if(value)
                {
                    Game.TickPlayerHUD += Tick;
                }
                else
                {
                    Game.TickPlayerHUD -= Tick;
                }

                _tickEnabled = value;
            }
        }



        protected virtual void Tick(TickArgs e)
        {
        }



        public virtual void Dispose()
        {
            TickEnabled = false;
        }
    }
}