using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTILS
{
    class NumerosLetras
    {
        static String[] Unidades = { "cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece",
            "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve"};

        static String[] Decenas = { "CERO", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

        static String[] Centenas = {"CERO", "ciento", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiscientos",
            "setecientos", "ochocientos", "novecientos"};

        static String[] UnidadMil ={"CERO", "mil", "dos mil","tres mil", "cuatro mil", "cinco mil", "seis mil", "siete mil", "ocho mil",
        "nueve mil",  "diez mil", "once mil", "doce mil", "trece mil", "catorce mil", "quince mil", "dieciseis mil", "diecisiete mil", "dieciocho mil", "diecinueve mil"};

        static String[] DecenasMil = {"cero", "diez mil", "veinte mil", "treinta mil", "cuarenta mil", "cincuenta mil", "sesenta mil",
            "setenta mil", "ochenta mil", "noventa mil"};

        static String[] CentenasMil = {"CERO", "cien mil", "doscientos mil", "trecientos mil", "cuatrocientos mil", "quinientos mil", "seiscientos mil",
            "setecientos mil", "ochocientos mil", "novecientos mil"};

        static String[] UnidadesMillon = { "cero", "un millon", "dos millones ", "tres millones", "cuatro millones", "cinco millones", "seis millones", "siete millones", "ocho millones", 
                "nueve millones", "diez millones", "once millones", "doce millones", "trece millones",
                "catorce millones", "quince millones", "dieciseis millones", "diecisiete millones", "dieciocho millones", "diecinueve millones"};

        static String[] DecenasMillon = { "CERO", "diez millones", "veinte millones", "treinta millones", "cuarenta millones", "cincuenta millones", "sesenta millones",
                "setenta millones", "ochenta millones", "noventa millones" };

        static String[] CentenasMillon = {"CERO", "cien millones", "doscientos millones", "trecientos millones", "cuatrocientos millones",
                "quinientos millones", "seiscientos millones", "setecientos millones", "ochocientos millones", "novecientos millones"};


        public static void TestUnidades()
        {
            //recorrer todo el array de String
            foreach (String cad in Unidades)
            {
                Console.WriteLine(cad);
            }
        }

        /// <summary>
        /// Devuelve el equivalente en letras para las unidades
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static String getUnidades(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = Unidades[num];

            return aux;
        }

        public static String getDecenas(int num)
        {
            String aux = "";
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
            {
                int residuo = num % 10;
                aux = Decenas[num / 10];
                if (residuo > 0)
                    aux += " y " + getUnidades(residuo);
            }
            return aux;
        }

        public static String getCentenas(int num)
        {

            String aux = "";
            int resi = num % 100;
            int residuo = num % 10;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = Centenas[num/100];
                aux += " " + getDecenas(resi);
            return aux;
        }

       


    }
}
