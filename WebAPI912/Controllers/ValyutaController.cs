using DataAccess.Context;
using DataAccess.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI912.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValyutaController : ControllerBase
    {
        AppDbContext dbContext = new AppDbContext();

        //1. Datani getirmek [HttpGet] - GetAll();
        [HttpGet]
        public IActionResult GetAll()
        {
            var values = dbContext.Valyutas.ToList();//Getirdim
            return Ok(values);
        }

        //2. Data Elave etmek [HttpPost] -Add();

        [HttpPost]
        public IActionResult Add(Valyuta v)
        {
            dbContext.Valyutas.Add(v);
            dbContext.SaveChanges(); //yadda saxlamaq
            return Ok();
        }

        //3. Data Redakte etmek [HttpPut] -Update();

        [HttpPut]
        public IActionResult Update(Valyuta v)
        {
            dbContext.Valyutas.Update(v);
            dbContext.SaveChanges(); //yadda saxlamaq
            return Ok();
        }

        //4. Data Silme etmek [HttpDelete] -Delete();
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            var values= dbContext.Valyutas.Find(id);//id axtarmaq
            dbContext.Valyutas.Remove(values); //id silmek
            dbContext.SaveChanges(); //yadda saxlamaq
            return Ok();
        
        }
    }
}
