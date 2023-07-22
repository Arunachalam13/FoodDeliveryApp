using Newtonsoft.Json;
using RealWorldApp.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldApp.Services
{
    public static class ApiService
    {
        public async static Task<bool> RegisterUser(string name, string email, string password)
        {
            var register = new Register()
            {
                Name = name,
                Email = email,
                Password = password
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(register);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://192.168.29.66:45457/api/Accounts/Register", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }
    }
}
