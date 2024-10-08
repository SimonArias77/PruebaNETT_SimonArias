using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaNET_SimónArias.Models;
using PruebaNET_SimónArias.Repositories;

namespace PruebaNET_SimónArias.Controllers.v1.Bookings;

[ApiController]
[Route("api/bookings")]
[Tags("bookings")]
public class BookingsPostController : BookingsController
{
    public BookingsPostController(IBookingRepository bookingRepository) : base(bookingRepository)
    {
    }

    [HttpPost]
    [Authorize]

    public async Task<IActionResult> AddOrderProduct(Booking booking)
    {
        await services.Add(booking);
        return Ok("booking created");
    }
}
