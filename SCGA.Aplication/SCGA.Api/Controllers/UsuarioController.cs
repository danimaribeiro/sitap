using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using SCGA.Dominio;
using SCGA.Api.Models;

namespace SCGA.Api.Controllers
{
    public class UsuarioController : ApiController
    {
        private Entity_Contexto db = new Entity_Contexto();

        // GET api/Usuario
        public IEnumerable<Usuario> GetUsuarios()
        {
            return db.Usuarios.AsEnumerable();
        }

        // POST api/Usuario/Validar
        public Usuario Validar(Dominio.DTO.DadosLogin dados)
        {
            var usuario = db.Usuarios.Where(x => x.Username == dados.Usuario && x.Senha == dados.Senha).SingleOrDefault();
             return usuario;
        }

        // GET api/Usuario/5
        public Usuario GetUsuario(long id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return usuario;
        }

        // PUT api/Usuario/5
        public HttpResponseMessage PutUsuario(long id, Usuario usuario)
        {
            if (ModelState.IsValid && id == usuario.Id)
            {
                db.Entry(usuario).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }
         
        // DELETE api/Usuario/5
        public HttpResponseMessage DeleteUsuario(long id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Usuarios.Remove(usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, usuario);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}