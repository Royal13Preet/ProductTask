using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsManagement.DataAccess.DBmodel
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; } = null!;

        [Range(1, int.MaxValue , ErrorMessage = "The Price Must Greater than Zero")]
        public int Price { get; set; }
    }
}
