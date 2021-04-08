using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.DTOs
{
    public class ProductDetailDto:IDto
    {
        //IEntity implemente edemeyiz cunku bu bir tablo degil.
        //IDto bir imzadir.
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInstock { get; set; }
    }
}
