using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ButterfliesShop.Validators;


namespace ButterfliesShop.Models
{
    public class Butterfly
    {
        public int Id { get; set; }
        [Display(Name = "Common Name:")]
        [Required(ErrorMessage = "Please enter the butterfly name")]
        public string CommonName { get; set; }
        [Display(Name = "Butterfly Family:")]
        [Required(ErrorMessage = "Please select the butterfly family")]
        public Family? ButterflyFamily { get; set; }
        [Display(Name = "Butterflies Quantity:")]
        [Required(ErrorMessage = "Please select the butterfly quantity")]
        [MaxButterflyQuantityValidation(50)]
        public int? Quantity { get; set; }
        [Required(ErrorMessage = "Please type the characteristics")]
        [StringLength(50)]
        [Display(Name = "Characteristics:")]
        public string Characteristics { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Updated on:")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Butterflies Picture:")]
        public IFormFile PhotoAvatar { get; set; }
        public string ImageName { get; set; }
        public byte[] PhotoFile { get; set; }
        public string ImageMimeType { get; set; }

    }
}
