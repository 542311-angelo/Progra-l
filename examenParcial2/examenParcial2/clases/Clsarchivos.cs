﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace examenParcial2.clases
{
    class Clsarchivos
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo, Encoding.Default);
            return Lineas;
        }
        public string LeertodoArchivo(string archivo)
        {
            string contenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                contenidoArchivo = reader.ReadToEnd();
            }
            return contenidoArchivo;
        }

    }
}
