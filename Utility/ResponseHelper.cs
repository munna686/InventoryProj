using InvenotryProj.Core.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Utility
{
    public static class ResponseHelper
    {
        public static IActionResult CustomApiResponse(this ControllerBase controller, ServiceResponse response)
        => response.Success ? controller.Ok(response) : controller.BadRequest(response);
    }
}
