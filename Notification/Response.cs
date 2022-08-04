using System.Collections.Generic;
using System.Linq;

namespace Notification
{
    public class Response
    {
        public Response(INotifiable notifiable) =>
            Notifications = notifiable.Notifications.Select(x => x.Message);

        public Response(INotifiable notifiable, object data)
        {
            Notifications = notifiable.Notifications.Select(x => x.Message);
            Data = data;
        }

        public void SetResult<TData>(TData data) where TData : class => Data = data;

        public void SetResult(object data) => Data = data;
       
        public IEnumerable<string> Notifications { get; private set; }
        public object Data { get; private set; }
    }
}
