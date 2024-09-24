using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
   internal class Libro
    {   // Aclaración sobre buenas prácticas: adopté la forma de codificar variables privadas de Diego colocando un guión bajo anteponiendo la primer letra minúscula para indicar que son privadas.
        private string _titulo;
        private string _autor;
        private string _genero;
        private int _precio;
        private bool _tapa_dura;
        private bool _disponibilidad;

        public Libro()
        {
            this.Titulo = "";
            this.Autor = "";
            this.Genero = "";
            this.Precio = 0;
            this.Tapa_dura = false;
            this.Disponibilidad = false;
        }

        public Libro(string titulo, string autor, string genero, int precio, bool tapa_dura, bool disponibilidad)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Genero = genero;
            this.Precio = precio;
            this.Tapa_dura = tapa_dura;
            this.Disponibilidad = disponibilidad;
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }

        public string Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }

        public int Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public bool Tapa_dura
        {
            get { return this._tapa_dura; }
            set { this._tapa_dura = value; }
        }

        public bool Disponibilidad
        {
            get { return this._disponibilidad; }
            set { this._disponibilidad = value; }
        }

        public float Precio_final
        {
            get { 
                if (this.Tapa_dura == true )
                {
                    return (Precio + (Precio / 10));
                }
                return Precio;
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Titulo: {this.Titulo} - Autor: {this.Autor} - Género: {this.Genero} - Precio Final: {this.Precio_final}");
        }

    }
}
