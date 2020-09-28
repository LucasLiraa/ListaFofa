using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database
{
    public class ListaFofaDatabase
    {
        Models.listafofadbContext db = new Models.listafofadbContext();
        public Models.TbListaFofa Salvar(Models.TbListaFofa lf)
        {
             db.Add(lf);
             db.SaveChanges();

             return lf;
        }

        public List<Models.TbListaFofa> Listar()
        {
             List<Models.TbListaFofa> lfs = db.TbListaFofa.ToList();
             return lfs;
        }
    }   
}