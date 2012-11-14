using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace POC.Api.Controllers
{
    public class UsuarioController : ApiController
    {        
        public IEnumerable<Dominio.Usuario> Get()
        {

            //TODO Usar diretamente o entity framework aqui para buscar os dados no banco.

            var userUm = new Dominio.Usuario() { Nome = "Teste" };
            var userDois = new Dominio.Usuario() { Nome = "Usuario dois" };
            return new Dominio.Usuario[] { userUm, userDois };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Dominio.Usuario user)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

    }
}
