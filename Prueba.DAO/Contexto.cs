﻿using Prueba.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO
{
    class Contexto: DbContext
    {
        public  Contexto():base("Contexto")
        {

        }

        public DbSet<Clase> Clases{ get; set; }

        public DbSet<Profesor>  Profesores { get; set; }
    }
}
