using System.ServiceModel;

namespace IcuTechLogin.Services;

[ServiceContract(Namespace = "urn:ICUTech.Intf-IICUTech")]
public interface IIcuTechService
{
    [OperationContract(Action = "urn:ICUTech.Intf-IICUTech#Login")]
    string Login(
        string UserName, 
        string Password, 
        string IPs);

    [OperationContract(Action = "urn:ICUTech.Intf-IICUTech#RegisterNewCustomer")]
    string RegisterNewCustomer(
        string Email, 
        string Password, 
        string FirstName, 
        string LastName, 
        string Mobile, 
        int CountryID, 
        int aID, 
        string SignupIP);
}

public class IcuTechSoapClient
{
    private readonly IIcuTechService _client;

    public IcuTechSoapClient()
    {
        var binding = new BasicHttpBinding();
        var endpoint = new EndpointAddress("http://isapi.mekashron.com/icu-tech/icutech-test.dll/soap/IICUTech");
        var factory = new ChannelFactory<IIcuTechService>(binding, endpoint);
        _client = factory.CreateChannel();
    }

    public async Task<string> LoginAsync(string username, string password, string ip)
    {
        return await Task.Run(() => _client.Login(
            username, 
            password, 
            ip));
    }

    public async Task<string> RegisterAsync(
        string email, 
        string password, 
        string firstName, 
        string lastName, 
        string mobile, 
        int countryId, 
        int aId, 
        string signupIp)
    {
        return await Task.Run(() => _client.RegisterNewCustomer(
            email, 
            password, 
            firstName, 
            lastName, 
            mobile, 
            countryId, 
            aId, 
            signupIp));
    }
}