﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Modulo3_Memoria_Arrays_Listas.Aula4_ModificadorDeParametros_Params
{
    internal class Calculadora
    {
        public static int Soma(params int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];


            }
            return soma;


        }
    }
}
