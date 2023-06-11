using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotNetCore6Static.Models;

public partial class Person
{
    [Key]
    public int Code { get; set; }

    public string? Name { get; set; }
}
