using ExelTechUI.Models;

namespace ExelTechUI
{
    public class DropDown
    {
        public List<Disease> GetAllDiseaseName()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl.BASE_URL);
            string newUrl = client.BaseAddress + "api/DropDown/GetAllDiseaseName";
            var responseTask = client.GetAsync(newUrl).Result;
            List<Disease> list = new List<Disease>();
            if (responseTask.IsSuccessStatusCode)
            {
                list = responseTask.Content.ReadFromJsonAsync<List<Disease>>().Result;
                if(list != null) {
                    return list;
                }
            }
            return list;
        }
        public List<NCD> GetAllNCD()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl.BASE_URL);
            string newUrl = client.BaseAddress + "api/DropDown/GetAllNCDList";
            var responseTask = client.GetAsync(newUrl).Result;
            List<NCD> list = new List<NCD>();
            if (responseTask.IsSuccessStatusCode)
            {
                list = responseTask.Content.ReadFromJsonAsync<List<NCD>>().Result;
                if (list != null)
                {
                    return list;
                }
            }
            return list;

        }
        public List<Allergy> GetAllAllergy()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseUrl.BASE_URL);
            string newUrl = client.BaseAddress + "api/DropDown/GetAllAllergyList";
            var responseTask = client.GetAsync(newUrl).Result;
            List<Allergy> list = new List<Allergy>();
            if (responseTask.IsSuccessStatusCode)
            {
                list = responseTask.Content.ReadFromJsonAsync<List<Allergy>>().Result;
                if (list != null)
                {
                    return list;
                }
            }
            return list;

        }
    }
}
