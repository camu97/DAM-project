using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGest
{
    enum ePosicion
    {
        NADA,
        PT,
        DEF,
        MC,
        DEL
    }
    class Jugador
    {
        public string nombre, apellidos, nick, comentarios;
        public DateTime fecha_nacimiento;
        public ePosicion posicion;

        public Jugador()
        {
            this.nombre = "";
            this.apellidos = "";
            this.nick = "";
            this.comentarios = "";
            this.fecha_nacimiento = DateTime.Parse("1 / 1 / 2222");
            this.posicion = ePosicion.NADA;
        }

        public Jugador(string nombre, string apellidos, string nick, string comentarios, DateTime fecha_nacimiento, ePosicion posicion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nick = nick;
            this.comentarios = comentarios;
            this.fecha_nacimiento = fecha_nacimiento;
            this.posicion = posicion;
        }
    }
}
