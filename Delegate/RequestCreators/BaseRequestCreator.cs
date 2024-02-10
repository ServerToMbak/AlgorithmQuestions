using System.Text.Json;

namespace Delegate.RequestCreators;

public class BaseRequestCreator
{

    protected delegate string GetBaseAddressDelegate();
    GetBaseAddressDelegate getBaseAddressDelegate;

    protected void SetBaseAddressMethod(GetBaseAddressDelegate paramDelegateMethod)
    {
        getBaseAddressDelegate = paramDelegateMethod;   
    }

    private string MakeGETRequest()
    {
        HttpClient client = new HttpClient();

        var baseAddress = getBaseAddressDelegate.Invoke();


        var msg = new HttpRequestMessage
        {
            Method = GetHttpMethod(),
            RequestUri = new Uri(baseAddress + GetUrlPath()),
        };
        

        var httpres = client.Send(msg);

        httpres.EnsureSuccessStatusCode();

        return httpres.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }

    private string MakePOSTRequest()
    {
        HttpClient client = new HttpClient();

        var baseAddress = getBaseAddressDelegate.Invoke();


        var msg = new HttpRequestMessage
        {
            Method = GetHttpMethod(),
            RequestUri = new Uri(baseAddress + GetUrlPath()),
        };

        var bodyContent = GetBodyObject();
        if (bodyContent != null)
            msg.Content = new StringContent(JsonSerializer.Serialize(bodyContent));


        var httpres = client.Send(msg);

        httpres.EnsureSuccessStatusCode();

        return httpres.Content.ReadAsStringAsync().GetAwaiter().GetResult();
    }

    protected string MakeRequests()
    {
       var method = GetHttpMethod();

        if(method == HttpMethod.Get)
            return MakeGETRequest();    
        else
            return MakePOSTRequest();   
    }



    protected virtual HttpMethod GetHttpMethod()
    {
        return HttpMethod.Get;  
    }
    protected virtual string GetUrlPath()
    {
        return "";
    }
    protected virtual object GetBodyObject()
    {
        return default;
    }
}
