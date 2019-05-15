using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGest
{
    public enum ePosicion
    {
        NADA,
        PT,
        DEF,
        MED,
        DEL
    }
    class Jugador
    {
        public string nombre, nick, comentarios,equipo;
        public DateTime fecha_nacimiento;
        public ePosicion posicion;

        public Jugador()
        {
            this.nombre = "";
            this.nick = "";
            this.comentarios = "";
            this.equipo = "";
            this.fecha_nacimiento = DateTime.Parse("1 / 1 / 2222");
            this.posicion = ePosicion.NADA;
        }

        public Jugador(string nombre, string equipo, string nick, string comentarios, DateTime fecha_nacimiento, ePosicion posicion)
        {
            this.nombre = nombre;
            this.equipo = equipo;
            this.nick = nick;
            this.comentarios = comentarios;
            this.fecha_nacimiento = fecha_nacimiento;
            this.posicion = posicion;
        }
    }
}
