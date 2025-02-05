﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : EntityBase
    {

        [Display(Name = "Имя")]
        public virtual string Name { get; set; }

        [Display(Name = "Фамилия")]
        public virtual string Surname { get; set; }

        [Display(Name = "Отчество")]
        public virtual string Patronimic { get; set; }
    }
}
