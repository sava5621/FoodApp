using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Java.Util.Jar.Attributes;
using Formatting = Newtonsoft.Json.Formatting;

namespace FoodApp.Services
{
    public class TokenServices
    {
        public TokenServices()
        {
            this.httpClient = new HttpClient();
            this.db = new dbServices();
        }
        HttpClient httpClient;
        dbServices db = new dbServices();
        string conectionSTR = "https://u1648633.plsk.regruhosting.ru/Auth";
        public async Task<string> GetAccToken()
        {
            UserToken token =await db.GetToken();
            Dictionary<string, string> param = new Dictionary<string, string>();
            param.Add("Id", token.Id);
            param.Add("Name", token.Name);
            param.Add("CreationT",token.CreationT);
            param.Add("DryingT", token.DryingT);
            param.Add("Email", token.Email);
            param.Add("Image", token.Image);
            param.Add("AccessToken", token.AccessToken);
            //
            var d = JsonConvert.SerializeObject(param, Formatting.Indented);
            return JsonConvert.SerializeObject(param, Formatting.Indented);
        }
        public async Task<bool> LoginAsync(string email, string pass)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();
            keys.Add("Email", email);
            pass = Encript(pass);
            keys.Add("Pass", pass);
            string json = JsonConvert.SerializeObject(keys, Formatting.Indented);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await httpClient.PostAsync(conectionSTR + "/Login", content);
            if (response.IsSuccessStatusCode)
            {
               await db.AddToken(
                    JsonConvert.DeserializeObject<Dictionary<string, string>>(
                    await response.Content.ReadAsStringAsync()));
                return true;
            }
            else return false;
        }
        public async Task<bool> Registr(string name, string email, string pass)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();
            keys.Add("Name", name);
            keys.Add("Email", email);
            pass = Encript(pass);
            keys.Add("Pass", pass);
            string json = JsonConvert.SerializeObject(keys);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await httpClient.PostAsync(conectionSTR + "/Registration", content);
            if (response.IsSuccessStatusCode)
            {
                await db.AddToken(
                     JsonConvert.DeserializeObject<Dictionary<string, string>>(
                     await response.Content.ReadAsStringAsync()));
                return true;
            }
            else return false;
        }
        public async Task<bool> RefreshAsync(UserToken token)
        {
            string json = JsonConvert.SerializeObject(token, Formatting.Indented);
            HttpContent content = new StringContent(json);
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await httpClient.PostAsync(conectionSTR + "/RefreshToken", content);
            if (response.IsSuccessStatusCode)
            {
                await db.RemoveToken();
                await db.AddToken(
                     JsonConvert.DeserializeObject<Dictionary<string, string>>(
                     await response.Content.ReadAsStringAsync()));
                return true;
            }
            else return false;
        }
        private string Encript(string data)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(data));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }

}
