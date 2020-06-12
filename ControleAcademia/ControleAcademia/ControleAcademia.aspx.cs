using ControleAcademia.Objetos;
using ControleAcademia.Objetos.DataAccess;
using ControleAcademia.Objetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Text;

namespace ControleAcademia
{

    public class GridParams
    {
        public string sidx;
        public string sord;
        public int page;
        public int rows;
        public bool _search;
        public string searchField;
        public string searchString;
        public string searchOper;
    }
    public partial class ControleAcademia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetAgendamentos();
        }

        private void desabilitarDataPassada()
        {
           //cldData.StartDate = DateTime.Now;
        }

        private void habilitarDataFutura()
        {
            //cldData.EndDate = (DateTime.Now).AddDays(1);            
        }

        private DateTime retornaDataBase()
        {
            DateTime dataBase = DateTime.Now;
            
            if (!IsPostBack)
            {
                txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                //09/06/2020
                
                dataBase = new DateTime
                    (
                        Convert.ToInt32(txtData.Text.Substring(6, 4)),
                        Convert.ToInt32(txtData.Text.Substring(3, 2)),
                        Convert.ToInt32(txtData.Text.Substring(0, 2))
                    );
            }
            
            return dataBase;
            
        }

        private void GetAgendamentos()
        {
            var dataBase = retornaDataBase();
            List<Agendamento> agendamentos = new List<Agendamento>();

            var dataAtual = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            if (dataBase >= dataAtual && dataBase <= dataAtual.AddDays(1))
            {
                agendamentos = AgendamentoDao.GetAgendamentos(dataBase);
                grdAgendamentos.DataSource = agendamentos;
                grdAgendamentos.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Data inválida para agendamento');</script>");
            }
        }
        

        [WebMethod]
        public static Reader<Agendamento> ListarAgendamentos(GridParams param)
        {
            var dataBase = DateTime.Now;
            List<Agendamento> agendamentos = new List<Agendamento>();
            
            if (param._search)
            {
                var operador = new Func<string, string, string>((op, valor) =>
                {
                    int saida;
                    bool isNum = Int32.TryParse(valor, out saida);
                    switch (op)
                    {
                        case "ne":
                            return isNum ? string.Format(" <>{0}", valor) : string.Format(" <>\"{0}\"", valor);
                        default:
                            return isNum ? string.Format(" = {0}", valor) : string.Format(" = \"{0}\"", valor);
                    }
                });

                var sb = new StringBuilder();
                sb.Append(param.searchField);
                sb.Append(operador(param.searchOper, param.searchString));
                agendamentos = AgendamentoDao.GetAgendamentos(dataBase);                              

            }
            else
            {
                agendamentos = AgendamentoDao.GetAgendamentos(dataBase);
            }

            var reader = new Reader<Agendamento>(agendamentos, param.page, param.rows);

            return reader;
        }

        protected void txtData_TextChanged(object sender, EventArgs e)
        {
            GetAgendamentos();
        }
    }
}