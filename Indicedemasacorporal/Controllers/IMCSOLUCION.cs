using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Objetos
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Palindromos
Nombre del alumno: Pedro Victor Ruvalcaba Novelo
Cuatrimestre: 4
Grupo: B
Parcial: 1
*/

namespace Indicedemasacorporal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMCSOLUCION : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCFinal(double altura, double peso)
        {
            var R = new Persona();
            R.Peso = peso;
            R.Altura = altura / 100;
            var AFinal = R.Altura;
            var IMC = peso / (AFinal * AFinal);
            var Clasificacion = "";



            if (IMC < 18.5)
            {
                Clasificacion = "Tienes un peso inferior a lo normal";
            }
            else
            {
                if (IMC >= 18.5 && IMC <= 24.9)
                {
                    Clasificacion = "Tienes un peso normal";
                }
                else
                {
                    if (IMC >= 25.0 && IMC <= 29.9)
                    {
                        Clasificacion = "Tienes un peso superior al normal";
                    }
                    else
                    {
                        Clasificacion = "Tienes obesidad";
                    }
                }
            }
            var Resultado = "Su IMC es: " + Convert.ToString(IMC) + "y su composicion corporal es: " + Clasificacion;
            return Ok(Resultado);
        }
    }
}
