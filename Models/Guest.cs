using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SimónArias.Models;

[Table("guests")]
public class Guest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    [MaxLength(255)]
    [Required]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(255)]
    [Required]
    public string? LastName { get; set; }

    [Column("email")]
    [MaxLength(255)]
    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Column("identification_number")]
    [MaxLength(20)]
    [Required]
    [RegularExpression("^[0-9]+$", ErrorMessage = "The identification number must be a number")]
    public string? IdentificationNumber { get; set; }

    [Column("phone_number")]
    [MaxLength(20)]
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string? PhoneNumber { get; set; }

    [Column("birth_date")]
    public DateOnly? BirthDate { get; set; }
}
