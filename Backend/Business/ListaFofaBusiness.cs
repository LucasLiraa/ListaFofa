using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Business
{
    public class ListaFofaBusiness
    {
        Database.ListaFofaDatabase db = new Database.ListaFofaDatabase();
        public Models.TbListaFofa Salvar(Models.TbListaFofa lf)
        {
            if (lf.NmFofura == string.Empty)
                throw new  Exception("Fofura é obrigatório.");
            if (lf.DsPorque == string.Empty)
                throw new  Exception("Porque é obrigatório.");

            return db.Salvar(lf);
        }

        public List<Models.TbListaFofa> Listar()
        {
            return db.Listar();
        }
    }
}