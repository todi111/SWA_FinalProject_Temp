﻿namespace CarService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;

    public class Model
    {
        private Brand brand;

        public Model(string name, Brand brand)
        {
            this.Name = name;
            this.Brand = brand;
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public bool isDeleted { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
