using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Biblioteca
{
    internal class Biblioteca
    {
        private string _nombre;
        private string _direccion;
        private List<Libro> libros_no_disponibles;
        private List<Libro> libros_disponibles;

        public Biblioteca()
        {
            this.Nombre = "";
            this.Direccion = "";
            this.libros_no_disponibles = new List<Libro>();
            this.libros_disponibles = new List<Libro>();
        }

        public Biblioteca(string nombre, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.libros_no_disponibles = new List<Libro>();
            this.libros_disponibles = new List<Libro>();
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }

        public void CargarListas()
        {
            libros_no_disponibles.Clear();
            libros_disponibles.Clear();
            FileStream Archivo;
            StreamReader leer;
            Archivo = new FileStream("libros.txt", FileMode.Open);
            leer = new StreamReader(Archivo);

            while (leer.EndOfStream == false)
                {
                bool tapa = false;
                bool dispo = false;
                
                string cadena = leer.ReadLine(); string[] datos = cadena.Split(';');

                if (datos[4] == "si")
                {
                    tapa = true;
                }

                if (datos[5] == "si") {
                    dispo = true;
                }

                Libro libro = new Libro(datos[0], datos[1], datos[2], int.Parse(datos[3]), tapa, dispo);
                    
                if (dispo == true)
                {
                    libros_disponibles.Add(libro);
                }
                else
                {
                    libros_no_disponibles.Add(libro);
                }
            }
            leer.Close();
            Archivo.Close();
        }
        public void GenerarReporte()
        {
            Console.WriteLine("\nListado de todos los libros de la biblioteca:");
            Console.WriteLine("\nListado de libros disponibles:");
            foreach (Libro libro in this.libros_disponibles)
            {
                libro.MostrarDatos();
            }

            Console.WriteLine("\nListado de libros no disponibles:");
            foreach (Libro libro in this.libros_no_disponibles)
            {
                libro.MostrarDatos();
            }

            Console.WriteLine("\nPrecione una tecla para continuar.");
        }
    }
}
