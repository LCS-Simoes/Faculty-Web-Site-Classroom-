using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Classes abaixos responsaveis pra enviar um email;
using System.Net.Mail;
using System.Net;

namespace Projeto3
{
    public partial class Faleconosco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Passo VALIDAR DADOS
                if (SeuNome.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu Nome";
                }
                else if (SeuEmail.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite seu E-mail";
                }
                else if (Conteudo.Text.Trim() == "")
                {
                    MensagemErro.Text = "Digite a Mensagem";
                }
                else
                {
                    // 2. Passo CRIAR O EMAIL
                    MailMessage email = new MailMessage();
                    email.To.Add("contato@NotLife.com.br");
                    MailAddress from = new MailAddress("contato@NotLife.com.br");
                    email.From = from;
                    email.Subject = "E-Mail enviado pelo form de Contato";
                    email.Body = "Nome: " + SeuNome.Text + "\n";
                    email.Body += "Email" + SeuEmail.Text + "\n";
                    email.Body += "Mensagem" + Conteudo.Text + "\n";

                    // 3. Passo Transmitir o E-mail
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.NotLife.com.br";
                    smtp.Credentials = new System.Net.NetworkCredential("contato@NotLife.com.br", "SuaSenha");
                    smtp.Send(email);
                }
            }
            catch (Exception)
            {
                MensagemErro.Text = "Houve uma falha no envio do E-mail";
                
            }






            
        }
    }
}