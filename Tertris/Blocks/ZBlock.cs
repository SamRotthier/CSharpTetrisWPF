using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertris
{
    public class ZBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            // State 0
            new Position[]{new(0,0), new(0,1), new(1,1), new(1,2)},
            // State 1
            new Position[]{new(0,2), new(1,1), new(1,2), new(2,1)},
            // State 2
            new Position[]{new(1,0), new(1,1), new(2,1), new(2,2)},
            // State 3
            new Position[]{new(0,1), new(1,0), new(1,1), new(2,0)}
        };

        public override int Id => 7;  // ZBlock identifier
        protected override Position StartOffset => new Position(0, 3);  // Based on the request
        protected override Position[][] Tiles => tiles;
    }
}
