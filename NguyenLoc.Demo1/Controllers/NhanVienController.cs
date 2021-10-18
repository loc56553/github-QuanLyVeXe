using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NguyenLoc.Demo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NguyenLoc.Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private readonly MyDbContext ctx;
        private IConfiguration config;
        public NhanVienController(MyDbContext _ctx, IConfiguration configuration)
        {
            ctx = _ctx;
            config = configuration;

        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<NhanVien> Get()
        {
            var nhanvien = ctx.NhanViens.AsNoTracking().ToList();
            return nhanvien;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest();
                }
                else
                {
                   var nhanVien = ctx.NhanViens.FirstOrDefault(nv => nv.MSNV == id);
                    if (nhanVien == null)
                    {
                        return NotFound();
                    }
                    else
                        return new ObjectResult(nhanVien);
                }    
                    
            }
              catch(Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NhanVien value)
        {
            try
            {
                if (value == null)
                    return BadRequest();
                else
                {
                    ctx.NhanViens.Add(value);
                    await ctx.SaveChangesAsync();
                    return new ObjectResult(value);
                }
            }
            catch (Exception) { return BadRequest(); }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] NhanVien value)
        {
            try
            {
                if (id == null)
                    return BadRequest();
                else
                {
                    var nhanVien = ctx.NhanViens.FirstOrDefault(nv => nv.MSNV == id);
                    if (nhanVien == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        //nhanVien.MSNV = id;
                        //nhanVien.TenNV = value.TenNV;
                        //nhanVien.Vitri = value.Vitri;
                        //nhanVien.Diachi = value.Diachi;
                        //ctx.NhanViens.Update(nhanVien);
                        nhanVien.Update(id, value);
                        await ctx.SaveChangesAsync();
                        return new ObjectResult(nhanVien);
                    }
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try {
                if (id==null)                
                    return NotFound();
                else
                {
                    var nhanVien = ctx.NhanViens.FirstOrDefault(nv => nv.MSNV == id);
                        if (nhanVien == null)
                    {
                        return BadRequest();
                    }
                       
                    else
                    {
                        ctx.NhanViens.Remove(nhanVien);
                        await ctx.SaveChangesAsync();
                        return StatusCode(200);
                    }
                    
                }
            }
            catch(Exception)
            {
                return BadRequest();
            }
            
        }
    }
}
