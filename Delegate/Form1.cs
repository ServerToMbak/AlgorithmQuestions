using Delegate.Models;
using Delegate.RequestCreators;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GetPostRequestCreator req = new GetPostRequestCreator();

            var posts =  req.GetPosts();

            MessageBox.Show("sadasd "+ posts.FirstOrDefault().Title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var req = new CreatePostRequestCreator();

            var createPost = req.CreatePost(new PostModel()
            {
                Title = "foo",
                Body = "bar",
                UserId = 1,
            });

            MessageBox.Show($"result id: {createPost.Id}");
            
        }
    }       
}
