using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasic.Models
{
    /// <summary>
    /// class : Fornecedor
    /// </summary>
    public class Supplier : Entity
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 11)]
        public string DocumentNumber { get; set; }
        public SupplierType SupplierType { get; set; }
        public Address Address { get; set; }
        
        [DisplayName("Ativo?")]
        public bool Active { get; set; }

        /**EF Relations **/
        public IEnumerable<Product> Products { get; set; }
    }
}
