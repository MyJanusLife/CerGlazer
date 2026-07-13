using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CerGlazer.Models;

[Keyless]
[Table("ConeType")]
public partial class ConeType
{
    public int Id { get; set; }

    public int ConeValue { get; set; }

    public int? ConeTemperature { get; set; }
}
