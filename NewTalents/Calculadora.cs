﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<String> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<String>();
        }

        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;
              listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public List<String> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}

