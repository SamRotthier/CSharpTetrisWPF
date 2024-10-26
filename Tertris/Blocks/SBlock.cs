﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertris
{
    public class SBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            // State 0
            new Position[]{new(0,1), new(0,2), new(1,0), new(1,1)},
            // State 1
            new Position[]{new(0,1), new(1,1), new(1,2), new(2,2)},
            // State 2
            new Position[]{new(1,1), new(1,2), new(2,0), new(2,1)},
            // State 3
            new Position[]{new(0,0), new(1,0), new(1,1), new(2,1)}
        };

        public override int Id => 5;  // SBlock identifier (as shown in the image)
        protected override Position StartOffset => new Position(0, 3);  // Based on the image
        protected override Position[][] Tiles => tiles;
    }
}
