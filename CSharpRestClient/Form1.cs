using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace CSharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetRes_Click(object sender, EventArgs e)
        {
            var URL = this.urlText.Text;
            var response = getResponse(URL);
            this.outputText.Text = await formatJSON(URL);
        }

        private async Task<string> getResponse(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            HttpClient client = new HttpClient();

            HttpResponseMessage res = await client.SendAsync(request);

            if (res.IsSuccessStatusCode)
            {
                return await res.Content.ReadAsStringAsync();
            }

            return string.Empty;
        }

        public async Task<string> formatJSON(string url)
        {
            var option = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonString = await getResponse(url);
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(jsonString);

            return JsonSerializer.Serialize(jsonElement, option);
        }
    }
}
