using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class clDate
    {
        //definimos los atributos
        private int _year;
        private int _month;
        private int _day;


        // creamos el constructor
        public clDate(int year, int month, int day) //le pasamos los parametros al constructor
        {
            _year = year;
            _month = CheckMonth(month);            //creams el metodo checkmonth
            _day = CheckDay(day, month, day);

        }

        private int CheckDay(int year, int month, int day)      //para validar el di se deben pasar los 3parametros x febrero y año bisiesto
        {
            if (month == 2 && day == 29 && biciesto(year))     //aqui se genera el metodo año biciesto
            {
                return day;

            }

            //  creamos un arrego x almacenar os dias por mes
            int[]diasPorMes = {0,31,28,31,30,31,30,31,31,30,31,30,31};
            if (day >=1 && day <= diasPorMes[month])           //
            {
                return day;

            }

            throw new DayException("--DIA INVALIDO--");
        }



        private bool biciesto(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;                  //si esmodulo de 400 ya es biciesto para todos tanto para 100 y 4
                                                                                            //esto evito miles de IF
        }

        private int CheckMonth(int month)             // validamos si un fecha MES es valido
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }                                           // mi clase date no debe intervenir con el usuario x eso no se coloca el console.write
            throw new MonthException("MES INVALIDO");      //SIGUE CON ERROR GENERAMOS LA CLASE           //creamos nuestra propia ecepcion
                                                           // AL ejecutar se genera error y x eso es mejor capturar el errror
        }

        public override string ToString()                 // con espacio para generar l metodo
        {
            return $"{_year }/ { _month:00}/{_day:00}";       //interpolacion siempre con $
        }



    }
}
