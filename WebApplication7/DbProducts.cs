using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class DbProducts
    {
        public static List<Products> GetProducts()
        {
            List<Products> productList = new List<Products>()
            {
                new Products(){product_id=1, product_name="Samsung Monitor", price="12129",product_description="Samsung IPS, Bezel Less, Flat, Flicker Free 1920 x 1080 Pixels LED Monitor-(Dark Blue Gray, 60.4 cm, 75 Hz) LF24T350FHWXXL"},
                new Products(){product_id=2, product_name="Realme_narzo", price="11000",product_description="realme narzo 50 (Speed Blue, 4GB RAM+64GB Storage) Helio G96 Processor | 50MP AI Triple Camera | 120Hz Ultra Smooth Display"},
                new Products(){product_id=3, product_name="oneplus_band", price="1129",product_description="OnePlus Smart Band: 13 Exercise Modes, Blood Oxygen Saturation (SpO2), Heart Rate & Sleep Tracking, 5ATM+Water & Dust Resistant( Android & iOS Compatible)"},
                new Products(){product_id=1, product_name="Track Pant", price="429",product_description="ENDEAVOUR WEAR Men's Regular Fit Trackpants"}
            };
            return productList;
        }
    }
}