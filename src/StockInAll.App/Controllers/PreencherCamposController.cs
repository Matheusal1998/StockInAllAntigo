using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using RestSharp;
using System.Web;
using IAStockInAll.Model;
using Newtonsoft.Json;

namespace StockInAll.App.Controllers
{
    public class PreencherCamposController : Controller
    {
        public async Task<IActionResult> Buscar(string mensagem)
        {
            var modelo = await MakeRequest(mensagem);

            return Json(new { sucesso = modelo});
        }

     
        static async Task<LuisResult> MakeRequest(string utterance)
        {
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["query"] = utterance;
            var predictionEndpointUri = String.Format("https://iastockinall.azurewebsites.net/Luis?mensagem={0}", utterance);

            var response = await client.GetAsync(predictionEndpointUri);

            var strResponseContent = await response.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<LuisResult>(strResponseContent);

            return model;
        }
    }
}
