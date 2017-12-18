using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetailNet.Data.Services.RqApiService
{
    public class RqApiService : IRqApiService
    {
        //Credentials provided by Api
        private string UserName = "";
        private string Password = "";
        private string ClientID = "";
        private string ClientSecret = "";
        private int CompanyID = 0;
        private RqApiAuthToken _token;
        public RqApiService()
        {
            CheckToken();
        }
        public void CheckToken()
        {
            if (_token == null || _token.expires_in < 60)
            {
                var client = new RestClient("https://accountsdemo.iqmetrix.net/v1/oauth2/token");
                var request = new RestRequest(Method.POST);
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("application/x-www-form-urlencoded", $"grant_type=password&username={UserName}&"
                                                                                            + $"password={Password}&"
                                                                                            + $"client_id={ClientID}&"
                                                                                            + $"client_secret={ClientSecret}", ParameterType.RequestBody);
                var response = client.Execute<RqApiAuthToken>(request);
                _token = response.Data;
            }

        }

        public void GettingAllLocationsForACompany()
        {
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/Locations");
            var request = new RestRequest(Method.GET);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");



            var test = client.Execute<List<RqApiStore>>(request);
        }
        //used for testing 
        public RqApiStore GetStore(int id)
        {
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/Locations({id})");
            var request = new RestRequest(Method.GET);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");



            var result = client.Execute<RqApiStore>(request);
            return result.Data;
        }

        public int CreateStore(int parentID, RqApiStore store)
        {
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/Tree/Nodes({parentID})/Locations");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", JsonConvert.SerializeObject(store), ParameterType.RequestBody);

            var result = client.Execute<RqApiStore>(request);
            return result.Data.Id;
        }

        public void UpdateStore(int parentID, RqApiStore store)
        {
            var oldStore = GetStore(store.Id);
            store.Version = oldStore.Version; //This is required by the API, the version number is incremented every time the store is updated. 
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/Tree/Nodes({parentID})/Locations({store.Id})");
            var request = new RestRequest(Method.PUT);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", JsonConvert.SerializeObject(store), ParameterType.RequestBody);

            var result = client.Execute<RqApiStore>(request);
        }

        public void MoveStore(int targetParentID, int storeID)
        {
            CheckToken();
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/tree/locations/move");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            var param = new RqApiMoveStoreParameter() { SubjectIds = new List<int>() { storeID }, DestinationId = targetParentID };
            request.AddParameter("application/json", JsonConvert.SerializeObject(param), ParameterType.RequestBody);
            var result = client.Execute<RqApiStore>(request);
        }

        public int CreateDivision(int parentID, RqApiDivision division, CorporateStructure level)
        {
            CheckToken();
            var client = new RestClient($"https://entitymanagerdemo.iqmetrix.net/v1/Companies({CompanyID})/Tree/Nodes({parentID})/{level.GetDescription()}" + "s");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Authorization", $"Bearer {_token.access_token}");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", JsonConvert.SerializeObject(division), ParameterType.RequestBody);

            var result = client.Execute<RqApiDivision>(request);
            return result.Data.Id;

        }

        
    }
}
