﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data.Proveedor
{
    public class ProveedorModel
    {
        public string id { get; set; }
        public string razon_social { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string direccion { get; set; }
        public string mail { get; set; }
        public string celular { get; set; }
        public string estado { get; set; }

    }
}
