using Model;
using Model.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Service
{
    public interface IUsuarioService
    {
        bool Create(Usuario model);
        IEnumerable<Usuario> ShowAll();
    }
    public class UsuarioService : IUsuarioService
    {
        private readonly ProyectoDbContext _context;

        public UsuarioService(ProyectoDbContext context)
        {
            _context = context;
        }
        public bool Create(Usuario model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }
        public IEnumerable<Usuario> ShowAll()
        {
            var result = new List<Usuario>();
            try
            {
                result = _context.Usuario.OrderByDescending(x => x.idusuario).ToList();
            }
            catch (Exception) { }
            return result;
        }
    }
}