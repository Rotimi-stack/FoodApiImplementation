using ApiFoodRest.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApiFoodRest.Controllers
{
    public class MealController : ApiController
    {
        string Baseurl = "https://nairabox-food-thirdparty-api.herokuapp.com/";

        [Authorize]
        public async Task<IEnumerable<Food>> getAllMeals()
        {
            List<Food> MealsInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage Res = await client.GetAsync("api/external/meal");

                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response Detail received from the web api
                    var mealsResponse = Res.Content.ReadAsStringAsync().Result;
                    //Deserializing the response received from web api and storing it into the Food List
                    MealsInfo = JsonConvert.DeserializeObject<List<Food>>(mealsResponse);
                }

                return (MealsInfo);
            }


        }
        [Authorize]
        [Route("api/Meal/mealCategory")]
        public async Task<IEnumerable<Food>> get()
        {
            List<Food> catInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage rep = await client.GetAsync("api/external/mealByCategory/5c8a20f4da5a0f0ac24dfd6c");

                if (rep.IsSuccessStatusCode)
                {
                    var catResponse = rep.Content.ReadAsStringAsync().Result;
                    catInfo = JsonConvert.DeserializeObject<List<Food>>(catResponse);
                }
                return (catInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/Restaurant")]
        public async Task<IEnumerable<Food>> GetmealByRestaurant()
        {
            List<Food> restInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage ret = await client.GetAsync("api/external/mealByRestaurant/5c92f7e961d6604250824d4f");
                if (ret.IsSuccessStatusCode)
                {
                    var restResponse = ret.Content.ReadAsStringAsync().Result;
                    restInfo = JsonConvert.DeserializeObject<List<Food>>(restResponse);
                }
                return (restInfo);
            }
        }

        [Authorize]
       [Route("api/Meal/Category")]
        public async Task<IEnumerable<Food>> getmealCategorys()
        {
            List<Food> caterInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage cate = await client.GetAsync("api/external/mealcategory");

                if (cate.IsSuccessStatusCode)
                {
                    var categResponse = cate.Content.ReadAsStringAsync().Result;
                    caterInfo = JsonConvert.DeserializeObject<List<Food>>(categResponse);
                }
                return (caterInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/allRest")]
        public async Task<IEnumerable<Food>> getAll()
        {
            List<Food> FooInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage bes = await client.GetAsync("api/external/restaurant/");
                if (bes.IsSuccessStatusCode)
                {
                    var besResponse = bes.Content.ReadAsStringAsync().Result;
                    FooInfo = JsonConvert.DeserializeObject<List<Food>>(besResponse);
                }
                return (FooInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/Featured")]
        public async Task<IEnumerable<Food>> getFeatured()
        {
            List<Food> RetInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage tes = await client.GetAsync("api/external/restaurantByFeatured/5");
                if (tes.IsSuccessStatusCode)
                {
                    var tesResponse = tes.Content.ReadAsStringAsync().Result;
                    RetInfo = JsonConvert.DeserializeObject<List<Food>>(tesResponse);
                }
                return (RetInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/One")]
        public async Task<IEnumerable<Food>> getOneById()
        {
            List<Food> eetInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage yes = await client.GetAsync("api/external/restaurant/5c92f7e961d6604250824d33");
                if (yes.IsSuccessStatusCode)
                {
                    var yesResponse = yes.Content.ReadAsStringAsync().Result;
                    eetInfo = JsonConvert.DeserializeObject<List<Food>>(yesResponse);
                }
                return (eetInfo);

            }
        }

        [Authorize]
        [Route("api/Meal/Location")]
        public async Task<IEnumerable<Food>> getByLocation()
        {
            List<Food> beetInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage bet = await client.GetAsync("api/external/restaurantBylocation/5c92c20f3e45e118c8fb72a7");
                if (bet.IsSuccessStatusCode)
                {
                    var betResponse = bet.Content.ReadAsStringAsync().Result;
                    beetInfo = JsonConvert.DeserializeObject<List<Food>>(betResponse);
                }
                return (beetInfo);
            }
        }


        [Authorize]
        [Route("api/Meal/Cuisine")]
        public async Task<IEnumerable<Food>> getcuisine()
        {
            List<Food> cusInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage cet = await client.GetAsync("api/external/cuisine");
                if (cet.IsSuccessStatusCode)
                {
                    var cetResponse = cet.Content.ReadAsStringAsync().Result;
                    cusInfo = JsonConvert.DeserializeObject<List<Food>>(cetResponse);
                }
                return (cusInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/Choice")]
        public async Task<IEnumerable<Food>> getselectChoice()
        {
            List<Food> sesInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage ses = await client.GetAsync("api/external/selectChoice");
                if (ses.IsSuccessStatusCode)
                {
                    var sesResponse = ses.Content.ReadAsStringAsync().Result;
                    sesInfo = JsonConvert.DeserializeObject<List<Food>>(sesResponse);
                }
                return (sesInfo);
            }
        }


        [Authorize]
        [Route("api/Meal/City")]
        public async Task<IEnumerable<Food>> getcity()
        {
            List<Food> citInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage cit = await client.GetAsync("api/external/city");
                if (cit.IsSuccessStatusCode)
                {
                    var citResponse = cit.Content.ReadAsStringAsync().Result;
                    citInfo = JsonConvert.DeserializeObject<List<Food>>(citResponse);
                }
                return (citInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/allLocation")]
        public async Task<IEnumerable<Food>> getallLocations()
        {
            List<Food> locInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage loc = await client.GetAsync("api/external/location");
                if (loc.IsSuccessStatusCode)
                {
                    var citResponse = loc.Content.ReadAsStringAsync().Result;
                    locInfo = JsonConvert.DeserializeObject<List<Food>>(citResponse);
                }
                return (locInfo);
            }
        }


        [Authorize]
        [Route("api/Meal/LocByCity")]
        public async Task<IEnumerable<Food>> getlocationByCity()
        {
            List<Food> lbcInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage lbc = await client.GetAsync("api/external/location");
                if (lbc.IsSuccessStatusCode)
                {
                    var citResponse = lbc.Content.ReadAsStringAsync().Result;
                    lbcInfo = JsonConvert.DeserializeObject<List<Food>>(citResponse);
                }
                return (lbcInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/Singleid")]
        public async Task<IEnumerable<Food>> getSingleById()
        {
            List<Food> wbcInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage wbc = await client.GetAsync("api/external/order/details/12343");
                if (wbc.IsSuccessStatusCode)
                {
                    var wbcResponse = wbc.Content.ReadAsStringAsync().Result;
                    wbcInfo = JsonConvert.DeserializeObject<List<Food>>(wbcResponse);
                }
                return (wbcInfo);
            }
        }

        [Authorize]
        [Route("api/Meal/Listid")]
        public async Task<IEnumerable<Food>> getListSingleById()
        {
            List<Food> wbcInfo = new List<Food>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage wbc = await client.GetAsync("api/external/order/list/12343");
                if (wbc.IsSuccessStatusCode)
                {
                    var wbcResponse = wbc.Content.ReadAsStringAsync().Result;
                    wbcInfo = JsonConvert.DeserializeObject<List<Food>>(wbcResponse);
                }
                return (wbcInfo);
            }
        }



        [Authorize]
        [Route("api/Meal/Walbal")]
        public async Task <Food> getwalletBalance()
        {
            Food fd  = new Food();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage wbc = await client.GetAsync("/api/external/balance");
                if (wbc.IsSuccessStatusCode)
                {
                    var wbcResponse = wbc.Content.ReadAsStringAsync().Result;
                  
                }
                return (fd);
            }
        }

       [HttpPost]
        [Route("api/Meal/ppd")]
        public async Task <IEnumerable<OrderGet>> Post( string email, string phoneNo)
        {
            List<OrderGet> wbcInfo = new List<OrderGet>();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
               // HttpResponseMessage ors = await client.PostAsJsonAsync("api/external/order/placeorder", new OrderGet { email = "timmytune002@gmail.com", phoneNo = "090664897896" });
                HttpResponseMessage ors = await client.PostAsJsonAsync("api/external/order/placeorder", new OrderGet { email = email , phoneNo = phoneNo});
                if (ors.IsSuccessStatusCode)
                {
                    var orsResponse = ors.Content.ReadAsStringAsync().Result;
                    wbcInfo = JsonConvert.DeserializeObject<List<OrderGet>>(orsResponse);
                }
                return (wbcInfo);
            }
        }


        [HttpPost] 
        [Route("api/Meal/pgd")]
        public async Task<OrderGet> Post(string email)
        {
            OrderGet ordInfo = new OrderGet();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Bearer 12345");
                HttpResponseMessage ors = await client.PostAsJsonAsync("api/external/order/get", new OrderGet { email = email});
                if (ors.IsSuccessStatusCode)
                {
                    var orsResponse = ors.Content.ReadAsStringAsync().Result;
                    ordInfo = JsonConvert.DeserializeObject<OrderGet>(orsResponse);
                }
                return (ordInfo);
            }
        }



    }
}
 
