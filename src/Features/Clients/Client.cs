using System;
using invoiceSystem.src.Features.Comunes;
namespace invoiceSystem.src.Features.Clients
{
    public class Client :Entity
    {
        public string ClientId {get;private set;}
        public string Name {get;private set;}
        public string Telephone {get;private set;}
        public string Address {get;private set;}
        public string Rtn {get;private set;}


    public abstract class ClientBuilder
    {
        private Client _client;
        public ClientBuilder()
        {
            _client = new Client();
        }
        public ClientBuilder WithClientId(string clientId )
        {
            _client.ClientId = clientId;
            return this;
        }
        public ClientBuilder WithName (string name)
        {
            _client.Name = name;
            return this;
        }
        public ClientBuilder WithAddress (string address)
        {
            _client.Address = address;
            return this;
        }
        public ClientBuilder WithTelePhone(string telePhone)
        {
            _client.Telephone = telePhone;
            return this;
        }
        public ClientBuilder WithRtn(string rtn)
        {
            _client.Rtn = rtn;
            return this;
        }
        public Client Build()
        {
            _client.IsDeleted = false;
            _client.ProcessDate = DateTime.Now;
            return _client;
        }
    }
    }
}