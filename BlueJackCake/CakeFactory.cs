using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlueJackCake
{
    public class CakeFactory
    {
        public static Cake create(string cakeName, int cakePrice, int cakeStock, string cakePic)
        {
            return new Cake()
            {
                CakeName = cakeName,
                Price = cakePrice,
                Stock = cakeStock,
                Picture = cakePic
            };
        }
    }
}