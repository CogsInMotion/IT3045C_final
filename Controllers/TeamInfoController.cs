using Microsoft.AspNetCore.Mvc;
using IT3045C_final.Models;

namespace IT3045C_final.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamInfoController(ILogger<TeamInfoController> logger) : Controller
{
    private readonly ILogger<TeamInfoController> _logger = logger;

    public IActionResult Get()
    {
        var teamMembers = new List<TeamInfo>
        {
            new() {
                ID = 1,
                Name = "Ben Stewart",
                Birthdate = "02-28-2002",
                CollegeProgram = "Information Technology",
                YearInProgram = "Junior"
            },
            new() {
                ID = 2,
                Name = "Patricia Echoles",
                Birthdate = "03-21-1991",
                CollegeProgram = "Information Technology",
                YearInProgram = "Sophomore"
            },
            // TODO: update with correct info
            new() {
                ID = 3,
                Name = "Madi Evanshine",
                Birthdate = "UNKNOWN",
                CollegeProgram = "UNKNOWN",
                YearInProgram = "UNKNOWN"
            },
            // TODO: update with correct info
            new() {
                ID = 4,
                Name = "Jacob Nolen",
                Birthdate = "UNKNOWN",
                CollegeProgram = "UNKNOWN",
                YearInProgram = "UNKNOWN"
            }
        };

        return Ok(teamMembers);
    }
}