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
                    aux += "  " + getUnidades(residuo);
            }
            return aux;
        }

        public static String getCentenas(int num)
        {

            String aux = "";
            int resi = num % 100;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
            {
                int residuo = num % 1000;
                aux = Centenas[num / 100];
                if (residuo > 0)
                    aux += "  " + getDecenas(residuo);
            }
            return aux;
        }

        public static String getUnidadMil(int num)
        {

            String aux = "";
            int resi = num % 1000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
            {
                int residuo = num % 1000;
                aux = UnidadMil[num / 1000];
                if (residuo > 0)
                    aux += "  " + getCentenas(residuo);
            }
            return aux;
        }

        public static String getDecenaMil(int num)
        {

            String aux = "";
            int resi = num % 10000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
                aux = getUnidadMil(num);
            else if (num >= 20000 && num < 100000)
            {
                int residuo = num % 10000;
                aux = DecenasMil[num / 10000];
                if (residuo > 0)
                    aux += "  " + getUnidadMil(residuo);
            }
            return aux;
        }

        public static String getCentenaMil(int num)
        {

            String aux = "";
            int resi = num % 100000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
                aux = getUnidadMil(num);
            else if (num >= 20000 && num < 100000)
                aux = getDecenaMil(num);
            else if (num >= 100000 && num < 900000)
            {
                int residuo = num % 100000;
                aux = CentenasMil[num / 100000];
                if (residuo > 0)
                    aux += "  " + getDecenaMil(residuo);
            }
            return aux;
        }

        public static String getUnidadMillon(int num)
        {

            String aux = "";
            int resi = num % 100000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
                aux = getUnidadMil(num);
            else if (num >= 20000 && num < 100000)
                aux = getDecenaMil(num);
            else if (num >= 100000 && num < 999999)
                aux = getCentenaMil(num);
            else if(num>=1000000 && num<20000000)
            {
                int residuo = num % 1000000;
                aux = UnidadesMillon[num / 1000000];
                if (residuo > 0)
                    aux += "  " + getCentenaMil(residuo);
            }
            return aux;
        }

        public static String getDecenaMillon(int num)
        {

            String aux = "";
            int resi = num % 100000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
                aux = getUnidadMil(num);
            else if (num >= 20000 && num < 100000)
                aux = getDecenaMil(num);
            else if (num >= 100000 && num < 999999)
                aux = getCentenaMil(num);
            else if (num >= 1000000 && num < 20000000)
                aux = getUnidadMillon(num);
            else if(num>=20000000 && num<99999999)
            {
                int residuo = num % 10000000;
                aux = DecenasMillon[num / 10000000];
                if (residuo > 0)
                    aux += "  " + getUnidadMillon(residuo);
            }
            return aux;
        }

        public static String getCentenaMillon(int num)
        {

            String aux = "";
            int resi = num % 100000;
            if (num >= 0 && num < 20)
                aux = getUnidades(num);
            else if (num >= 20 && num < 100)
                aux = getDecenas(num);
            else if (num >= 100 && num < 1000)
                aux = getCentenas(num);
            else if (num >= 1000 && num < 20000)
                aux = getUnidadMil(num);
            else if (num >= 20000 && num < 100000)
                aux = getDecenaMil(num);
            else if (num >= 100000 && num < 999999)
                aux = getCentenaMil(num);
            else if (num >= 1000000 && num < 20000000)
                aux = getUnidadMillon(num);
            else if (num >= 20000000 && num < 100000000)
                aux = getDecenaMillon(num);
            else if(num>= 100000000 && num<1000000000)
            {
                int residuo = num % 100000000;
                aux = CentenasMillon[num / 100000000];
                if (residuo > 0)
                    aux += "  " + getDecenaMillon(residuo);
            }
            return aux;
        }





    }

       


}

