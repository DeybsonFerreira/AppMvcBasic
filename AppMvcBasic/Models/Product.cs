using System;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    public class Product : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Description { get; set; }
       
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Image { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Value { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }

        /*Propriedade de navegação*/
        public Guid SupplierId { get; set; }

        /*EF Relations*/
        public Supplier Supplier { get; set; }

    }
}
