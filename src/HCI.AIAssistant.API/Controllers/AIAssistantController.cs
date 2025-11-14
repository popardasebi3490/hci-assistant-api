using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCI.AIAssistant.API.Models.DTOs.AIAssistantController;
using Microsoft.AspNetCore.Mvc;

namespace HCI.AIAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{
    [HttpPost("/message")]
    public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync([FromBody]AIAssistantControllerPostMessageRequestDTO request)
    {
        AIAssistantControllerPostMessageResponseDTO response = new ()
        {
            TextMessage = "Hi" + request.TextMessage
        };

        return Ok(response);
    }
}
