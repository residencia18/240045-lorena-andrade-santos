using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechAdvocacia.Application.InputModel
{
    public class NewCasoJuridicoInputModel
    {

        public required string Status { get; set; }
        public int ClienteId { get; set; }
    }
}