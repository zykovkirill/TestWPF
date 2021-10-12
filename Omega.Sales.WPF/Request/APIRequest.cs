using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Omega.Sales.WPF
{
    /// <summary>
    /// Список API запросов на сервер
    /// </summary>
    class APIRequest
    {

        private static string Get(string uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Запрос не удался {ex.Message}");
                return null;
            }
        }
        /// <summary>
        /// Возвращает список обьектов (запрос GET) по url
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="url">Ссылка(API.URL)</param>
        /// <returns></returns>
        public static async Task<List<T>> GetObjectAsync<T>(string url)
        {

            string str = await Task<string>.Run(() => Get(url));
            if (str != null)
            {
                List<T> tbx_N_Parts = JsonSerializer.Deserialize<List<T>>(str);
                return tbx_N_Parts;
            }
            return null;
        }
    }
}
