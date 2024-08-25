using Course.Shared.DTOs;
using Course.SharedNew.ControllerBases;
using CourseServices.PhotoStock.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseServices.PhotoStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : CustomBaseController
    {
        [HttpPost]
        public async Task<IActionResult> PhotoSave(IFormFile photo,CancellationToken cancellationToken)
        {
            if (photo != null && photo.Length>0) 
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", photo.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                await photo.CopyToAsync(stream,cancellationToken);

                var returnPath = "photos/" + photo.FileName;

                PhotoDto photoDto = new() { Url = returnPath };

                return CreateActionResultInstance(Response<PhotoDto>.Success(photoDto, 200));
            }


            return CreateActionResultInstance(Response<PhotoDto>.Fail("Photo is Empty",400));
        }
    }
}
