﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModMarca
    {
        private int id;
        private string descricao;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
