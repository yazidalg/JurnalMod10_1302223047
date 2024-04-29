using Microsoft.AspNetCore.Mvc;
using System;
namespace JurnalMod10_1302223047.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mahasiswa : ControllerBase
    {
        private static List<ModelMahasiswa> listOfMahasiswa = new List<ModelMahasiswa>
        {
            new ModelMahasiswa("Al", "1302223047", 2022, ["IMK", "PBO"]),
        };

        [HttpGet]
        public IEnumerable<ModelMahasiswa> Get()
        {
            return listOfMahasiswa;
        }

        [HttpGet("{id}")]
        public ModelMahasiswa Get(int id)
        {
            return listOfMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] ModelMahasiswa mahasiswa)
        {
            listOfMahasiswa.Add(mahasiswa);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ModelMahasiswa mahasiswa)
        {
            listOfMahasiswa[id] = mahasiswa;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listOfMahasiswa.RemoveAt(id);
        }
    }
}
