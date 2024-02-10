using Delegate.Models;
using System.Text.Json;

namespace Delegate.RequestCreators;

public class GetPostRequestCreator : BaseRequestCreator
{
    public GetPostRequestCreator()
    {
        base.SetBaseAddressMethod(() => "https://jsonplaceholder.typicode.com/");
    }
    public List<PostModel> GetPosts()
    {
   
        var responseContent = base.MakeRequests();

        return JsonSerializer.Deserialize<List<PostModel>>(responseContent, new JsonSerializerOptions(JsonSerializerDefaults.Web));
    }



    protected override HttpMethod GetHttpMethod()
    {
        return HttpMethod.Get;
    }

    protected override string GetUrlPath()
    {
        return "posts";
    }

}
