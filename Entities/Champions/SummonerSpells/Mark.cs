﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Mark : SummonerSpell
    {
        public long GetCooldown()
        {
            return 40L;
        }

        public long GetRange()
        {
            return 1600L;
        }
    }
}
