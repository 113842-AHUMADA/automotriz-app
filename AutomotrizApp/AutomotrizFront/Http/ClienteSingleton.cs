﻿using AutomotrizBack.datos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizFront.Http
{
    internal class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;
        public string PrivilegioUsuario = "";
        public string nombreUsuario = "";

        private ClienteSingleton()
        {
            client = new HttpClient();
        }

        public static ClienteSingleton ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<loginDTO> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(url, content);
            loginDTO response = new loginDTO();
            
            if (result.IsSuccessStatusCode) response = JsonConvert.DeserializeObject<loginDTO>(await result.Content.ReadAsStringAsync())!;
            return response;
        }

        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
    }
}
