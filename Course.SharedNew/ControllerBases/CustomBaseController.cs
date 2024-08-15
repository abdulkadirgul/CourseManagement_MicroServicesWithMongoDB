using Course.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.SharedNew.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            // Response null ise 500 Internal Server Error döndür
            if (response == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Internal server error: Response is null.");
            }

            // Eğer response.StatusCode 0 ise, default olarak 500 Internal Server Error ata
            if (response.StatusCode == 0)
            {
                response.StatusCode = StatusCodes.Status500InternalServerError;
            }

            // response nesnesini dön
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }

}
