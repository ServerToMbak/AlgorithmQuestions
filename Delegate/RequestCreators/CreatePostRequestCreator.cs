using Delegate.Models;
using System.Text.Json;

namespace Delegate.RequestCreators
{
    public class CreatePostRequestCreator : BaseRequestCreator
    {
        private PostModel _postModel;

        public CreatePostRequestCreator()
        {
            base.SetBaseAddressMethod(()=> "https://jsonplaceholder.typicode.com/");
        }

        public PostModel CreatePost(PostModel postModel)
        {
            _postModel = postModel; 

            var responseContent = base.MakeRequests();

            return JsonSerializer.Deserialize<PostModel>(responseContent, new JsonSerializerOptions(JsonSerializerDefaults.Web));  
        }

        protected override object GetBodyObject()
        {
            return _postModel;
        }

        protected override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Post;
        }

        protected override string GetUrlPath()
        {
            return "posts";
        }

    }


}
