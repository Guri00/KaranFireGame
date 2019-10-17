using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaranFireGame
{
    public    class details
    {
        // this method is used to load the image of the gun
        public String load() {
            return "k2";
        }

        // this method is used to spin the image of the gun
        public String spin()
        {
            return "k3";
        }

        // this method is used to shoot the image of the gun
        public String shoot()
        {
            return "k4";
        }
        //main condition to play the game 
        public int chances(int y) {
            if (y == 1)
            {
                return 1;
            }
            else if (y == 2)
            {
                return 2;
            }
            else {
                return 0;
            }
        }

    }
}
