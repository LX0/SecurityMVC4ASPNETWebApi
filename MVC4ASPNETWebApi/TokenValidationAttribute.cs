using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;

namespace MVC4ASPNETWebApi
{
    public class TokenValidationAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            String token;

            #region Verifica la presenza del token
            try
            {
                token = actionContext.Request.Headers.GetValues("Authorization-Token").First();
            }
            catch (Exception)
            {
                actionContext.Response =
                  new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest) { Content = new StringContent("Authorization-Token non presente") };
                return;
            }
            #endregion

            #region Verifica la correttezza del token fisso
            RSAClass.ChiavePrivata = Token.ChiavePrivata;
            RSAClass.ChiavePubblica = Token.ChiavePubblica;
            try
            {
                token = RSAClass.Decrypt(token);
                String TokenFisso = token.Split(new Char[] { ';' })[0];
                if (TokenFisso != Token.Value)
                    throw new Exception();
            }
            catch (Exception)
            {
                actionContext.Response =
                            new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent("Authorization-Token non valido") };
                return;
            }
            #endregion

            #region Verifica che il token variabile non sià già stato utilizzato
            try
            {
                String TokenVariabile = token.Split(new Char[] { ';' })[1];

                if (Token.GetTokens().FirstOrDefault(x => x == TokenVariabile) != null)
                    throw new Exception();
                else
                    Token.AddToken(TokenVariabile);
            }
            catch (Exception)
            {
                actionContext.Response =
                            new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent("Authorization-Token già utilizzato") };
                return;
            }
            #endregion

            #region Verifica che il token non sia corrotto
            try
            {
                String UrlRichiesta = token.Split(new Char[] { ';' })[2];

                var context = actionContext.Request.Properties["MS_HttpContext"] as System.Web.HttpContextBase;
                //string userIP = context.Request.UserHostAddress;

            }
            catch (Exception)
            {
                actionContext.Response =
                            new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden) { Content = new StringContent("Authorization-Token corrotto") };
                return;
            }
            #endregion
        }
    }
}