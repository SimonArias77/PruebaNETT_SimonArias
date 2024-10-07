using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaNET_SimónArias.DTOs.Requests;

public class RegisterDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? IdentificationNumber { get; set; }
    public string? Password { get; set; }
}
