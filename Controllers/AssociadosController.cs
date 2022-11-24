using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Linq;
using WebApp2.Models;

namespace WebApp2.Controllers
{
    
    public class AssociadosController : ApiController
    {
        // GET: Associados
        [HttpGet]
        [Route("api/SelecionarTodos")]
        public IEnumerable<Associado> SelecionarTodos()
        {
            List<Associado> lista = new List<Associado>();
            try
            {
                PVProautoEntities db = new PVProautoEntities();               
                lista = db.Associado.ToList();
            }
            catch (Exception ex)
            {
                Associado associado = new Associado();
                associado = new Associado();
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
                lista.Add(associado);
            } 

            return lista;
        }





        [HttpGet]
        [Route("api/SelecionarPorId")]
        public Associado SelecionarPorId(int Id)
        {
            Associado associado = new Associado();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                associado = db.Associado.Where(c => c.Id == Id).FirstOrDefault();
                associado = associado == null ? new Associado() : associado;
            }
            catch (Exception ex)
            {
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
            }

            return associado;
        }




        [HttpGet]
        [Route("api/SelecionarPorPlaca")]
        public  Associado SelecionarPorPlaca(string placa)
        {            
            Associado associado = new Associado();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                associado = db.Associado.Where(c => c.Placa.ToUpper().Replace(".","").Replace("-", "") == placa.ToUpper().Replace(".", "").Replace("-", "")).FirstOrDefault();
                associado = associado == null ? new Associado() : associado;

            }
            catch (Exception ex)
            {
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
            }

            return associado;
        }
        
        [HttpGet]
        [Route("api/SelecionarPorCPF")]
        public Associado SelecionarPorCPF(string cpf)
        { 
            Associado associado = new Associado();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                associado = db.Associado.Where(c => c.CPF.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "") == cpf.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "")).FirstOrDefault();

                associado = associado == null ? new Associado() : associado;
            }
            catch (Exception ex)
            {
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
            }
            return associado;
        }

        [HttpGet]
        [Route("api/SelecionarPorCpfPlaca")]
        public Associado SelecionarPorCpfPlaca(  string cpf, string placa)
        {
            Associado associado = new Associado();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                associado = db.Associado.Where(c => c.CPF.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "") == cpf.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "") &&
                                                    c.Placa.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "") == placa.ToUpper().Replace(".", "").Replace("-", "").Replace("/", "")
                ).FirstOrDefault();

                associado = associado == null ? new Associado() : associado;
            }
            catch (Exception ex)
            {
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
            }
            return associado;
        }

        [HttpGet]
        [Route("api/SelecionarPorNome")]       
        public Associado SelecionarPorNome(string Nome)
        {
            Associado associado = new Associado();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                associado = db.Associado.Where(c => c.Nome.ToUpper().Contains( Nome.ToUpper() )).FirstOrDefault();

                associado = associado == null ? new Associado() : associado;
            }
            catch (Exception ex)
            {
                associado.Id = 0;
                associado.Nome = "Erro: " + ex.Message;
            }

            return associado ;
        }

        // Posts: Associados
        [HttpPost]
        [Route("api/Incluir")]
        public async Task<Retorno> Incluir([FromBody] Associado associado) 
        {
            int id = 0;
            string MsgErro = "Cliente não pode ser incluído, erro:";                      

            Retorno retorno = new Retorno();
            try
            {
                PVProautoEntities db = new PVProautoEntities();

                if (String.IsNullOrEmpty(associado.Nome))
                {
                    return await Getorno(0, $@"{MsgErro} Informe o nome do associado", "Erro");
                }

                else if (String.IsNullOrEmpty(associado.CPF))
                {
                    return await Getorno(0, $@"{MsgErro} Informe o CPF do associado.", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.Placa))
                {
                    return await Getorno(0, $@"{MsgErro} Informe a Placa do automóvel do associado.", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.Logradouro))
                {
                    return await Getorno(0, $@"{MsgErro}  Informe o Logradouro do associado", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.Numero))
                {
                    return await Getorno(0, $@"{MsgErro} Informe o número da residência do  associado.", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.Bairro))
                {
                    return await Getorno(0, $@"{MsgErro} Informe o bairro do associad.", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.Cidade))
                {
                    return await Getorno(0, $@"{MsgErro} Informe a cidade do associado.", "Erro");
                }
                else if (String.IsNullOrEmpty(associado.UF))
                {
                    return await Getorno(0, $@"{MsgErro} Informe a UF do associado.", "Erro");
                }
                else
                {
                    associado.CPF = associado.CEP.Replace(".", "").Replace("-", "").Replace("/", "");
                    associado.Placa = associado.Placa.Replace(".", "").Replace("-", "");
                    associado.TelefoneCeluar = associado.TelefoneCeluar == null ? "" : associado.TelefoneCeluar.Replace(".", "").Replace("-", "");
                    associado.TelefoneFixo = associado.TelefoneFixo == null ? "" : associado.TelefoneFixo.Replace(".", "").Replace("-", "");
                    associado.CEP = associado.CEP == null ? "" : associado.CEP.Replace(".", "").Replace("-", "");

                    var novo =  db.Associado.Where(c => c.Nome == associado.Nome && c.CPF.Trim() == associado.CPF && c.Placa.Trim() == associado.Placa).FirstOrDefault();

                    if (novo != null)
                    {
                        return await Getorno(id, $@"{MsgErro} já cadastrado", "Erro");
                    }
                    else
                    {   
                        db.Associado.Add(associado);
                        db.SaveChanges();

                        var novocliente = db.Associado.Where(c => c.Nome == associado.Nome && c.CPF.Trim() == associado.CPF && c.Placa.Trim() == associado.Placa).FirstOrDefault();

                        return await Getorno(novocliente.Id, "Associado incluso com sucesso", "OK");
                    }
                }



            }
            catch (Exception ex)
            {
                retorno.CodItem = associado.Id;
                retorno.Mensagem = "Erro na inserção, erro: " + ex.Message;
                retorno.Status = "OK";
            }


            return retorno;

        }

        [HttpPost]
        [Route("api/Alterar")]
        public async Task<Retorno> Alterar([FromBody] Associado associado)
        {

            int id = associado.Id == null ? 0 : associado.Id;
            Retorno retorno = new Retorno();

            try
            {
                PVProautoEntities db = new PVProautoEntities();
                var novo =  db.Associado.Where(c => c.Id == id).FirstOrDefault();

                if (novo == null)
                {
                    return await Getorno(id, $@"Assocido não alterado,erro: associdado não encontrado", "Erro");
                }
                else
                {
                    novo.CEP = associado.CEP.Replace(".","").Replace("-", "");
                    novo.Logradouro = associado.Logradouro;
                    novo.Numero = associado.Numero;
                    novo.Complemento = associado.Complemento;
                    novo.Bairro = associado.Bairro;
                    novo.Cidade = associado.Cidade;
                    novo.UF = associado.UF;

                    db.Entry(novo).State = EntityState.Modified;

                    db.SaveChanges();
                    return await Getorno(id, "Assocido alterado com sucesso.", "OK");
                }
            }
            catch(Exception ex) 
            {
                retorno.CodItem = associado.Id;
                retorno.Mensagem = "Erro na edição, erro: "+ ex.Message;
                retorno.Status = "OK";
            }


            return retorno;
        }

        private async Task<Retorno> Getorno(int Id, String Mensagem, string Sucesso)
        {
            Retorno retorno = new Retorno();

            retorno.CodItem = Id;
            retorno.Mensagem = Mensagem;
            retorno.Status = Sucesso;
            return retorno;
        }
    }
}
