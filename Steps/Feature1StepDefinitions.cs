using System;
using TechTalk.SpecFlow;
using RestSharp;

namespace Homework
{
    [Binding]
    public class WebAPIStepDefinitions
    {
        private static API c1 = new API();
        private RestClient client_upload = c1.Get_Upload_client();
        private RestClient client_get_metadata = c1.Get_GerMetadata_client();
        private RestClient client_delete = c1.Get_Delete_client();
        private RestRequest firstrequest = c1.CreateRequest();
        private RestRequest secondrequest = c1.CreateRequest();
        private RestRequest thirdrequest = c1.CreateRequest();

        public class Feature1StepDefinitions
    {
        [Given(@"we have file to upload")]
        public void GivenWeHaveFileToUpload()
        {
                c1.Timeout(client_upload);
            }

        [When(@"We send request to upload")]
        public void WhenWeSendRequestToUpload()
        {
                c1.Upload_Request(firstrequest);
            }

        [Then(@"We get uploaded file")]
        public void ThenWeGetUploadedFile()
        {
                IRestResponse responce = c1.Responce(client_upload, request1);
                Assert.AreEqual((int)responce.StatusCode, 200);

            }

            [Given(@"We have file to get metadata")]
        public void GivenWeHaveFileToGetMetadata()
        {
                c1.Timeout(client_get_metadata);
            }

        [When(@"We send request to get metadata")]
        public void WhenWeSendRequestToGetMetadata()
        {
                c1.GetMetadata_Request(secondrequest);
            }

        [Then(@"We get metadata")]
        public void ThenWeGetMetadata()
        {
                IRestResponse responce = c1.Responce(client_get_metadata, request2);
                Assert.AreEqual((int)responce.StatusCode, 200);
            }

        [Given(@"We have file to delete")]
        public void GivenWeHaveFileToDelete()
        {
                c1.Timeout(client_delete);
            }

        [When(@"We send request to delete")]
        public void WhenWeSendRequestToDelete()
        {
                c1.Delete_Request(thirdrequest);
            }

        [Then(@"We responce that file delited")]
        public void ThenWeResponceThatFileDelited()
        {
                IRestResponse responce = c1.Responce(client_delete, request3);
                Assert.AreEqual((int)responce.StatusCode, 200);
            }
    }
}
