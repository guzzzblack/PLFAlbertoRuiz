using Model;
using Model.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Service
{
    public interface ICategoriaService
    {
        bool Create(Categorias model);
        IEnumerable<Categorias> ShowAllcat();
    }
    public class CategoriaService : ICategoriaService
    {
        private readonly ProyectoDbContext _context;

        public CategoriaService(ProyectoDbContext contextcat)
        {
            _context = contextcat;
        }
        public bool Create(Categorias model)
        {
            try
            {
                _context.Entry(model).State = EntityState.Added;
                _context.SaveChanges();
                return true;
            }
            catch (Exception) { return false; }
        }
        public IEnumerable<Categorias> ShowAllcat()
        {
            var result = new List<Categorias>();
            try
            {
                result = _context.Categorias.OrderByDescending(x => x.idcategoria).ToList();
            }
            catch (Exception) { }
            return result;
        }
    }
}