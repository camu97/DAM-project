using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGest
{
    class Equipo
    {
        public string nombre, categoria, liga;
        public List<Jugador> jugadores;

        public Equipo()
        {
            this.nombre = "";
            this.categoria = "";
            this.liga = "";
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, string categoria, string liga)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.liga = liga;
            this.jugadores = new List<Jugador>();
        }

    }
}
