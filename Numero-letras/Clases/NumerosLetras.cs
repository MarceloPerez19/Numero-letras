﻿using System;
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

        static String[] Decenas = { "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };

        static String[] Centenas = {"cien", "doscientos", "trecientos", "cuatrocientos", "quinientos", "seiscientos",
            "setecientos", "ochocientos", "novecientos"};

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

    }
}
