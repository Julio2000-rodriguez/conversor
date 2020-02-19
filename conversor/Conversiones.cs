using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor
{
    class Conversiones
    {
        public string[] Tipo = { "Moneda", "Longitud", "Peso", "Volumen", "Almacenamiento", };


        public string[][] etiquetas =
        {
            new string [] {"Dolar","Colones el salvador","Yenes","Rupias","Lempiras", "Peso Mexicanos","BitCoin", "Quetzal", "Euro","Cordoba","Balboa","Peso Argentino", "Peso Chileno", "Peso Colombiano", "Soles peruanos", "Dolar Canadiense", "Dolar Beliceño"},

            new string [] {"Metro", "Cm", "Pulgada", "pie", "Varas","Yardas","Km","Millas", "Milimetro","MicroMetro", "NanoMetro"},

            new string [] {"Kilogramo","Gramo","Miligramo","MicroGramo","Libra","Onza", "Tonelada", "Stone"},
            
            new string [] {"Litro", "MiliLitro", "Metro Cubico", "Galon", "Pie Cubico", "Taza Americana"},
            
            new string [] {"MegaBytes", "KiloBytes", "GigaBytes", "TeraBytes", "PentaBytes", "ExaBytes", "Bit", "Byte"},
      
        };


        double[][] valores =
        {
            new double[] { 1, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02 },

            new double[] { 1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371, 1000, 1e+6, 1e+9 },

            new double[] {1, 1000, 1e+6 , 1e+9, 2.20462, 35.274, 0.001, 0.157473 },
            
            new double[] {1, 1000, 0.001, 0.264172, 0.0353147, 4.167 },

            new double[] {1, 24, 1440, 86400, 0.14285714285714285, 0.06666666666666667, 0.03287671232876712, 0.0027397260273972603 },
                   
            new double[] {1,100, 1e-4, 3.861e-5, 119.599, 1076.391, 155000.31, 0.01 }
        };

        public double convertir(int de, int a, double cantidad, int opcion)
        {
            return Math.Round(valores[opcion][a] / valores[opcion][de] * cantidad, 2);
        }

    }
}

