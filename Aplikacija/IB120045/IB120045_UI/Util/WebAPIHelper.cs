
using IB120045_API.Models;
using IB120045_API.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IB120045_UI.Util
{
    public class WebAPIHelper
    {
        private HttpClient client { get; set; }
        private string route { get; set; }
        public WebAPIHelper(string uri, string route)
        {
            client = new HttpClient();
            client.Timeout = TimeSpan.FromMinutes(10);
            client.BaseAddress = new Uri(uri);
            this.route = route;
        }

        public HttpResponseMessage GetResponse()
        {
            return client.GetAsync(route).Result;
        }



        public HttpResponseMessage GetResponse(string parametar)
        {
            //api/Korisnik
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse(string parametar)
        {
            //api/Korisnik
            return client.GetAsync(route + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse2(string v, string text)
        {
            return client.GetAsync(route + "/" + v + "/" + text).Result;
        }
        public HttpResponseMessage GetActionResponse2(string v, string text, bool status)
        {
            return client.GetAsync(route + "/" + v + "/" + text + "/" + status).Result;
        }
        public HttpResponseMessage GetActionResponse(string v, int parm1, int parm2,int parm3)
        {
            return client.GetAsync(route + "/" + v + "/" + parm1 + "/" + parm2 + "/" + parm3).Result;
        }
        public HttpResponseMessage PostResponse(object obj)
        {
            return client.PostAsJsonAsync(route, obj).Result;

        }
        public HttpResponseMessage postDelete(int id)
        {
            return client.DeleteAsync(route + "/DeleteAktovnosti/" + id).Result;
        }
        public HttpResponseMessage GetActionResponse(string v1, int parametar)
        {
            return client.GetAsync(route + "/" + v1 + "/" + parametar).Result;
        }
        public HttpResponseMessage GetActionResponse(string v1, bool aktivan, bool izmireneObaveze)
        {
            return client.GetAsync(route + "/" + v1 + "/" + aktivan + "/" + izmireneObaveze).Result;
        }

        public HttpResponseMessage PostActionResponse(string action, Object newObject)
        {

            return client.PostAsJsonAsync(route + "/" + action, newObject).Result;

        }
        public HttpResponseMessage GetActionResponse(string action, string parameter = "", string datumDO = null, bool aktivan = false)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter).Result;
        }
        public HttpResponseMessage GetActionResponse(string action, bool aktivan = false)
        {
            return client.GetAsync(route + "/" + action + "/" + aktivan).Result;
        }
        public HttpResponseMessage GetActionResponseResponse2(string action, string parameter = "", string parameter2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter2).Result;
        }

        public HttpResponseMessage GetActionResponseResponse3(string action, string parameter = "", string parameter2 = "", int id = 0, int id2 = 0)
        {
            return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter2 + "/" + id + "/" + id2).Result;
        }


        public HttpResponseMessage PostResponseKorisnici(Zaposlenici k)
        {
            return client.PostAsJsonAsync(route, k).Result;

        }
        public HttpResponseMessage PutResponse(int id, object existingObject)
        {
            return client.PutAsJsonAsync(route + "/" + id, existingObject).Result;
        }
        public HttpResponseMessage DeleteResponse(string r,int id)
        {

            return client.DeleteAsync(route + "/" + r + "/" + id).Result;

        }
        public HttpResponseMessage DeleteResponse(string r, int id,int dijagnozaID)
        {

            return client.DeleteAsync(route + "/" + r + "/" + id + "/" + dijagnozaID).Result;

        }
        public HttpResponseMessage postUpdate(int id, object obj)
        {
            return client.PostAsJsonAsync(route + "/Update/" + id, obj).Result;
        }
    }
}
