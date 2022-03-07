using Model;
using Model.Domain;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Service
{
         public interface ITareaService
        {
            bool Create(Tareas model);
            IEnumerable<Tareas> ShowAlltar();
        }
        public class TareaService : ITareaService
        {
            private readonly ProyectoDbContext _context;

            public TareaService(ProyectoDbContext contexttar)
            {
                _context = contexttar;
            }
            public bool Create(Tareas model)
            {
                try
                {
                    _context.Entry(model).State = EntityState.Added;
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception) { return false; }
            }
            public IEnumerable<Tareas> ShowAlltar()
            {
                var result = new List<Tareas>();
                try
                {
                    result = _context.Tareas.OrderByDescending(x => x.idtarea).ToList();
                }
                catch (Exception) { }
                return result;
            }
        }
}
