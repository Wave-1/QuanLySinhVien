using System.Net.Http.Json;

namespace WinFormsApp_SV
{
    public class QuanLySinhVien
    {
        HttpClient client = new HttpClient();
        string path = "https://localhost:7217/SinhVien/";

        public async Task<string> Get()
        {
            string product = "";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsStringAsync();
            }
            return product;
        }

        public async Task<int> Create(SinhVien sv)
        {
            try
            {
                HttpResponseMessage response = await client.PostAsJsonAsync(
                    path, sv);
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public async Task<int> Delete(string id)
        {
            try
            {
                HttpResponseMessage response = await client.DeleteAsync(
                    path + $"?id={id}");
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }

        public async Task<int> Update(SinhVien sv)
        {
            try
            {
                HttpResponseMessage response = await client.PutAsJsonAsync(
                path + $"?id={sv.Id}", sv);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                    return 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return 0;
        }
        public async Task<string> Search(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string product = await response.Content.ReadAsStringAsync();
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
