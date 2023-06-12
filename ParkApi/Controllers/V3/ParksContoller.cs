using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Threading.Tasks;
using System.Security.Cryptography;

// Uses Random generator
// Uses Pagenation
// Uses JWT *currently not working*

namespace ParkApi.Controllers.v3
{
  [Authorize]
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("3.0")]
  public class ParksController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public ParksController(ParkApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string parkName, string state, string description, int pageNumber = 1, int pageSize = 5)
    {
      var query = _db.Parks.AsQueryable();

      if (parkName != null)
      {
        query = query.Where(entry => entry.ParkName == parkName);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State == state);
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      query = query.Skip((pageNumber - 1) * pageSize);

      query = query.Take(pageSize);

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    [HttpGet("random")]
    public async Task<ActionResult<Park>> GetRandom()
    {
      List<Park> parks = await _db.Parks.ToListAsync();
      Random rand = new Random();
      return parks[rand.Next(parks.Count)];
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    [HttpGet("token")]
    [AllowAnonymous]
    public IActionResult GetToken()
    {
      var secretKey = "secret-key";
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

      var claims = new[] {
          new Claim(JwtRegisteredClaimNames.Sub, "Subject"),
          new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
          new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.Now.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
          new Claim("iss", "localhost"),
          new Claim("aud", "school-project")
      };

      var token = new JwtSecurityToken(
          claims: claims,
          signingCredentials: credentials
      );

      var tokenHandler = new JwtSecurityTokenHandler();
      var serializedToken = tokenHandler.WriteToken(token);

      return Ok(serializedToken);
    }

    private SymmetricSecurityKey GenerateSecurityKey()
    {
      var keyBytes = new byte[32];
      using (var rng = RandomNumberGenerator.Create())
      {
          rng.GetBytes(keyBytes);
      }
    return new SymmetricSecurityKey(keyBytes);
    }
  }
}