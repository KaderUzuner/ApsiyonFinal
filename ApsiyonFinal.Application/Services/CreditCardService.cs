using ApsiyonFinal.Application.DTOs;
using ApsiyonFinal.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApsiyonFinal.Application.Services
{
    public class CreditCardService : ICreditCardService
    {
        private readonly HttpClient _httpClient;

        public CreditCardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private async Task Login(string userName, string password)
        {
            var json = JsonSerializer.Serialize(new { userName = userName, password = password });
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var uri = new Uri($"{_httpClient.BaseAddress}auth/login");
            var response = await _httpClient.PostAsync(uri, content);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var apiResult = JsonSerializer.Deserialize<ApiResult>(result);

                JwtToken.Token = apiResult.Token;
                JwtToken.ValidDate = DateTime.Now.AddHours(2);
            }



        }
        public async Task<bool> WithdrawMoney(CreditCardDto creditCardDto)
        {

            if (string.IsNullOrWhiteSpace(JwtToken.Token))

            {
                await Login("ab", "ab");
            }

            if (JwtToken.ValidDate < DateTime.Now) await Login("a", "a");

            //geçerlilik tarihi

            string json = JsonSerializer.Serialize(creditCardDto);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {JwtToken.Token}");

            var uri = new Uri($"{_httpClient.BaseAddress}banking/withdrawmoney");

            var response = await _httpClient.PostAsync(uri, content);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();

                return bool.Parse(result);
            }

            return false;
        }
    }
}
