using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoIdentity.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [DisplayName("Tài khoản")]
        public string UserId { get; set; }

        // Navigation reference property cho khóa ngoại đến Account
        [ForeignKey("UserId")]
        [DisplayName("Tài khoản")]
        public ApplicationUser User { get; set; }

        [DisplayName("Sản phẩm")]
        public int ProductId { get; set; }

        // Navigation reference property cho khóa ngoại đến Product
        [DisplayName("Sản phẩm")]
        public Product Product { get; set; }

        [Required(ErrorMessage = "{0} không được bỏ trống")]
        [DefaultValue(1)]
        public int Quantity { get; set; } = 1;
    }
}
