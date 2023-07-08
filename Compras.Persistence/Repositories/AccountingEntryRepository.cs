using Compras.Application.Contracts.Persistence;
using Compras.Domain.Domains;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Compras.Persistence.Repositories;

public class AccountingEntryRepository : IAccountingEntryRepository
{

    


    public async  Task<IEnumerable<AccountingEntry>> GetAccountingEntriesFilteredByAux(int auxId)
    {
        string baseURL = $"http://129.80.203.120:5000/get-accounting-entries/auxiliar={auxId}";

        var apiRes = await GetApiResponse(baseURL);
        return apiRes;

    }

    public async Task  SendAccountingEntryToContabilidad(AccountingEntryDto accountingEntry)
    {
        string baseURL = "http://129.80.203.120:5000/post-accounting-entries";


        var json = JsonConvert.SerializeObject(accountingEntry);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        using var client = new HttpClient();

        var response = await client.PostAsync(baseURL, data); 

        var result= await response.Content.ReadAsStringAsync(); 

        

        Console.WriteLine(result);

      
    }


    private async Task<IEnumerable<AccountingEntry>> GetApiResponse(string endpoint)
    {
        using var client = new HttpClient();

        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        HttpResponseMessage response = await client.GetAsync(endpoint);
        string apiResponse = await response.Content.ReadAsStringAsync();

        JObject json = JObject.Parse(apiResponse);



        Console.WriteLine(json["asientocontable"]);
        var result = JsonConvert.DeserializeObject<List<AccountingEntry>>((json["asientocontable"].ToString())); 

        return result;  
    }
}
