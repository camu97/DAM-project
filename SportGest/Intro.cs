using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Intro : Form
    {
        private int cont = 0, intervalo = 0;
        private Random gen;
        public Intro()
        {
            InitializeComponent();

            //Crear la BD y las tablas
            {
                try
                {
                    if (!File.Exists(Directory.GetCurrentDirectory() + "SportGest_Database.db3"))
                    {
                        System.Data.SQLite.SQLiteConnection.CreateFile(Directory.GetCurrentDirectory() + "SportGest_Database.db3");
                    }
                    SQLiteConnection cnn = new SQLiteConnection(Properties.Settings.Default.SportGestConnection);
                    SQLiteCommand cmd = new SQLiteCommand(cnn);
                    cnn.Open();


                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS [Equipos] (
                            [Id]            INTEGER       NOT NULL    PRIMARY KEY AUTOINCREMENT ,
                            [nombre]        VARCHAR (50)  NOT NULL,
                            [categoria]     VARCHAR (50)  NOT NULL,
                            [liga]          VARCHAR (50)  NULL,
                            [num_jugadores] INTEGER       NULL,
                            [observaciones] VARCHAR (300) NULL
                    )";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS [Notas] (
                            [id]    INTEGER           PRIMARY KEY AUTOINCREMENT NOT NULL,
                            [fecha] DATE          NOT NULL,
                            [nota]  VARCHAR (500) NOT NULL
                    )";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS [Jugadores] (
                        [id]               INTEGER           PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [num]              INTEGER           NOT NULL,
                        [nombre]           VARCHAR (50)  NOT NULL,
                        [nick]             VARCHAR (20)  NULL,
                        [posicion]         VARCHAR (50)  NULL,
                        [fecha_nacimiento] DATE          NOT NULL,
                        [equipo]           VARCHAR (50)  NOT NULL,
                        [observaciones]    VARCHAR (300) NULL
                    )";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS [Partidos](
                        [Id]               INTEGER            PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [fecha]            DATETIME       NOT NULL,
                        [equipo_local]     VARCHAR (300)  NOT NULL,
                        [equipo_visitante] VARCHAR (300)  NOT NULL,
                        [goles_local]      INTEGEREGER        NOT NULL,
                        [goles_visitante]  INTEGEREGER		NOT NULL,
                        [resultado]        VARCHAR (200)  NOT NULL,
                        [jornada]          VARCHAR (100)  NULL,
                        [competicion]      VARCHAR (200)  NOT NULL,
                        [campo]            VARCHAR (200)  NOT NULL,
                        [estilo_atq]       VARCHAR (200)  NOT NULL,
                        [estilo_def]       VARCHAR (200)  NOT NULL,
                        [posicion_atq]     VARCHAR (200)  NOT NULL,
                        [posicion_def]     VARCHAR (200)  NOT NULL,
                        [calentamiento]    VARCHAR (3000) NOT NULL,
                        [observaciones]    VARCHAR (3000) NOT NULL,
                        [titulares]        VARCHAR (2000) NOT NULL,
                        [suplentes]        VARCHAR (2000) NOT NULL,
                        [cambios]          VARCHAR (2000) NOT NULL,
                        [condicion]        VARCHAR (100)  NOT NULL
                    )";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"CREATE TABLE IF NOT EXISTS [Entrenamientos] (
                        [Id]                        INTEGER            PRIMARY KEY AUTOINCREMENT NOT NULL,
                        [fecha]                     DATETIME       NOT NULL,
                        [objetivo]                  VARCHAR (50)   NOT NULL,
                        [duracion]                  INTEGER            NOT NULL,
                        [descripcion]               VARCHAR (200)  NOT NULL,
                        [calentamiento_descripcion] VARCHAR (1000) NOT NULL,
                        [principal_descripcion]     VARCHAR (1000) NOT NULL,
                        [calma_descripcion]         VARCHAR (1000) NOT NULL,
                        [equipo]                    VARCHAR (100)  NOT NULL,
                        [t_calentamiento]           INTEGER            NOT NULL,
                        [t_principal]               INTEGER            NOT NULL,
                        [t_calma]                   INTEGER            NOT NULL,
                        [mat_calentamiento]        VARCHAR (200)  NULL,
                        [mat_principal]             VARCHAR (200)  NULL,
                        [mat_calma]                 VARCHAR (200)  NULL
                    )";
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            //try
            //{
            //    SQLiteConnection cnn = new SQLiteConnection(Properties.Settings.Default.SportGestConnection);
            //    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Jugadores]", cnn);
            //    cmd.CommandType = CommandType.Text;
            //    cnn.Open();
            //    SQLiteDataReader dr = cmd.ExecuteReader();
            //    string s = "";
            //    while (dr.Read())
            //    {
            //        s += dr["nombre"].ToString() + "\r\n";
            //    }
            //    MessageBox.Show(s);
            //}
            //catch (SQLiteException)
            //{
            //    MessageBox.Show("DIME ALGO");
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            gen = new Random();
            intervalo = gen.Next(2500, 5000);
            timer1.Start();
            timer1.Interval = intervalo;
            //timer1.Interval = 5;
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont % 2 == 0)
            {
                pbIntro.Location = new Point(pbIntro.Location.X, pbIntro.Location.Y + 30);
            }
            else
            {
                pbIntro.Location = new Point(pbIntro.Location.X, pbIntro.Location.Y - 30);
            }
        }
    }
}
