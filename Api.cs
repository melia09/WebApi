using RestSharp;

namespace WebAPI
{
    class API
    {
        public RestClient Get_Upload_client()
        {
            RestClient client = new RestClient("https://content.dropboxapi.com/2/files/upload");
            return client;
        }

        public RestClient Get_GetMetadata_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");
            return client;
        }

        public RestClient Get_Delete_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/delete");
            return client;
        }

        public RestClient Get_List_Folder_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/list_folder");
            return client;
        }

        public RestRequest CreateRequest()
        {
            RestRequest request = new RestRequest(Method.POST);
            return request;
        }

        public void Timeout(RestClient cl)
        {
            cl.Timeout = -1;
        }
        public void Upload_Request(RestRequest firstrequest)
        {
            
            firstrequest.AddHeader("Dropbox-API-Arg", "{\"path\": \"/lab.jpeg\",\"mode\": \"add\",\"autorename\": true,\"mute\": false,\"strict_conflict\": false}");
            firstrequest.AddHeader("Content-Type", "application/octet-stream");
            firstrequest.AddHeader("Authorization", "Bearer sl.A-aiF9ND3wfKr_nyoGGSkNBdcbbTgyLVKZ-BEKSfvZaOQf_12rTa-ClwPAgf6c7ibL6iLDyDNZUByMR6G61-OUuUmuLcdHUpelF24qEuO8pmLbQE5UgobYZGCsGf_ssj3egGq2UFDwX0");
        }


        public void GetMetadata_Request(RestRequest secondrequest)
        {
            secondrequest.AddHeader("Authorization", "Bearer sl.A-bGTGcJcbMya8FllljFb87kfDgOZSqi15ow3Lv0sb9dSNUxhEzWXSXyFooSdUABCpqP_nk3hsi_Cxt9SjO_t-xjEKEKPLOcBcu4XwnXF8_3G86ThT0NIs9eY__stlgFUI8BaA6jz6KA"); 
            secondrequest.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
@"        ""path"": ""/lab.jpeg"",
" + "\n" +
@"        ""include_media_info"": false,
" + "\n" +
@"        ""include_deleted"": false,
" + "\n" +
@"        ""include_has_explicit_shared_members"": false
" + "\n" +
@"    }";
            secondrequest.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        public void Delete_Request(RestRequest thirdrequest)
        {
            thirdrequest.AddHeader("Authorization", "Bearer sl.A-bGTGcJcbMya8FllljFb87kfDgOZSqi15ow3Lv0sb9dSNUxhEzWXSXyFooSdUABCpqP_nk3hsi_Cxt9SjO_t-xjEKEKPLOcBcu4XwnXF8_3G86ThT0NIs9eY__stlgFUI8BaA6jz6KA"); 
            thirdrequest.AddHeader("Content-Type", "application/json");
            var body = @"{
" + "\n" +
@"    ""path"": ""/lab.jpeg""
" + "\n" +
@"}";
            thirdrequest.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        
        public IRestResponse Responce(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }

    }
}