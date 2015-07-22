using Microsoft.WindowsAzure.Mobile.Service;

namespace AnyBlogAPI.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}