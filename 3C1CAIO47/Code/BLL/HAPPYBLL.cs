using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3C1CAIO47.Code.DTO;
using _3C1CAIO47.Code.DAL;
using System.Data;

namespace _3C1CAIO47.Code.BLL
{
    internal class ProdutoBLL
    {
        BANCO bd = new BANCO();
        string tabela = "happy";



        public void Inserir(HAPPYDTO lojasDTO)
        {

            string inserir = $"insert into {tabela} values('{ lojasDTO.Id}','{ lojasDTO.Produto}','{ lojasDTO.Preco}')";
            bd.ExecutarComando(inserir);
        }


        public void Excluir(HAPPYDTO lojasDTO)
        {
            string excluir = $"delete from {tabela} where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela}; ";
            return bd.ExecutarConsulta(sql);
        }
        public void Editar(HAPPYDTO lojasDTO)
        {
            string alterar = $"update {tabela} set produto = '{lojasDTO.Produto}', preco = '{lojasDTO.Preco}' where id = '{lojasDTO.Id}';";
            bd.ExecutarComando(alterar);
        }
    }
}
