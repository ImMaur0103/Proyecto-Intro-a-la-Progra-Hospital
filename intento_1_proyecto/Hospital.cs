using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intento_1_proyecto
{
    class Hospital
    {
        public int total_medicos;
        public int total_camillas = 20;
        public int total_sillaruedas = 20;
        public int[] medicos_especiales = new int[6];
        public string[] especialidad = new string[6];
        public void medicos()
        {
            Random x = new Random();
            for (int i = 0; i < 6; i++)
            {
                int cant_espesialidad = x.Next(10, 30);
                if (i == 0)
                {
                    especialidad[0] = "traumatología";
                    medicos_especiales[0] = cant_espesialidad;
                }
                else if (i == 1)
                {
                    especialidad[1] = "pediatría";
                    medicos_especiales[1] = cant_espesialidad;
                }
                else if (i == 2)
                {
                    especialidad[2] = "anestesiología";
                    medicos_especiales[2] = cant_espesialidad;
                }
                else if (i == 3)
                {
                    especialidad[3] = "oftalmología";
                    medicos_especiales[3] = cant_espesialidad;
                }
                else if (i == 4)
                {
                    especialidad[4] = "ginecología";
                    medicos_especiales[4] = cant_espesialidad;
                }
                else if (i == 5)
                {
                    especialidad[5] = "fisioterapia";
                    medicos_especiales[5] = cant_espesialidad;
                }
            }
            total_medicos = medicos_especiales[0] + medicos_especiales[1] + medicos_especiales[2] + medicos_especiales[3] + medicos_especiales[4] + medicos_especiales[5];
        }
        public void medicos1()
        {
            total_medicos = medicos_especiales[0] + medicos_especiales[1] + medicos_especiales[2] + medicos_especiales[3] + medicos_especiales[4] + medicos_especiales[5];
        }
    }
}
