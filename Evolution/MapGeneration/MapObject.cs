﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.MapGeneration
{
    [Serializable]
    public struct MapObject
    {
        public int x, y;
        public int level;
        public int food;
        public List<object> objectsOnTile;

        public void Tick()
        {
            //food++;
        }
    }
}
