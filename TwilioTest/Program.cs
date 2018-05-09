using System;
using RestSharp;
using RestSharp.Authenticators;

namespace TwilioTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            //2
            var request = new RestRequest("Accounts/AC600d33d12250881c23268a6e5e15d03c/Messages", Method.POST);
            //3
            request.AddParameter("To", "+19498747568");
            request.AddParameter("From", "+19513972262");
            request.AddParameter("Body", "Hello world!");
            //4
            client.Authenticator = new
                HttpBasicAuthenticator("AC600d33d12250881c23268a6e5e15d03c", "579a3ee73658605546bd490f30aacf3e");
            //5
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response);
            });
            Console.ReadLine();
        }
    }
}