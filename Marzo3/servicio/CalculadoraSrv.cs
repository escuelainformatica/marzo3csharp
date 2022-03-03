using Marzo3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Marzo3.servicio.CalculadoraSrv




namespace Marzo3.servicio
{
    public class CalculadoraSrv
    {
        /// <summary>
        /// Esta funcion, yo le entrego dos decimales
        /// y devuelve un objeto del tipo calculadora
        /// </summary>
        public Calculadora Factory(decimal cuadro1,decimal cuadro2, decimal cuadro3)
        {
            // 1) Crear una calculadora
            Calculadora calc = new Calculadora();
            // 2) llenarlo con datos
            calc.Num1 = cuadro1;
            calc.Num2 = cuadro2;
            calc.Num3 = cuadro3;
            // 3) regresar
            return calc;
        }
        /// <summary>
        /// yo le paso un objeto del tipo calculadora, y devuelve la suma
        /// </summary>
        public decimal Sumar(Calculadora calc)
        {
            return calc.Num1 + calc.Num2+calc.Num3;
        }
        public decimal Restar(Calculadora calc)
        {
            return calc.Num1 - calc.Num2-calc.Num3;
        }
        public decimal Multiplicar(Calculadora calc)
        {
            return calc.Num1 * calc.Num2*calc.Num3;
        }
        public decimal Dividir(Calculadora calc)
        {
            // == igual     =
            // != no igual  <>
            // &&           and
            // || (al lado izquierdo numero 1)  or  

            if(calc.Num2==0 || calc.Num3==0)
            {
                return 0;
            } else {
                return calc.Num1 / calc.Num2/calc.Num3;
            }
            
        }
    }
}
