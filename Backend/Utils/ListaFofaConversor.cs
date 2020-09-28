using System;
using System.Collections.Generic;

namespace Backend.Utils
{
    public class ListaFofaConversor
    {
         public Models.TbListaFofa ParaTabela(Models.Request.ListaFofaRequest request)
         {
             Models.TbListaFofa lf = new Models.TbListaFofa();
             lf.NmFofura= request.Fofura;
             lf.DsPorque = request.Porque;
             lf.DtNiver = request.Niver;
             lf.BtColocariaPotinho = request.ColocariaPotinho; 

             return lf;
         }

         public Models.Response.ListaFofaResponse ParaResponse(Models.TbListaFofa lf)
        {
            Models.Response.ListaFofaResponse resp = new Models.Response.ListaFofaResponse();
            resp.Id = lf.IdListaFofa;
            resp.Fofura = lf.NmFofura;
            resp.Porque = lf.DsPorque;
            resp.Niver = lf.DtNiver;
            resp.ColocariaPotinho = lf.BtColocariaPotinho;
                
            return resp;
        }

        public List<Models.Response.ListaFofaResponse> ParaResponse(List<Models.TbListaFofa> lfs)
        {
            List<Models.Response.ListaFofaResponse> resp = new List<Models.Response.ListaFofaResponse>();
            foreach (Models.TbListaFofa item in lfs)
            {
                resp.Add(
                    this.ParaResponse(item));
            }
            return resp;
        }
    }
}