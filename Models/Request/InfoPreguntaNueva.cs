using Questionadosnet.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Questionadosnet.Models.Request
{
    public class InfoPreguntaNueva
    {

        public string Enunciado;

        public List<Respuesta> Opciones;

        public int CategoriaId;
    }
}
