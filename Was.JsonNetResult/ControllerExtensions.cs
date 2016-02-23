namespace Was.JsonNetResult
{
    using System.Text;
    using System.Web.Mvc;

    public static class ControllerExtensions
    {
        public static JsonResult JsonNet(this Controller controller, object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding,
                JsonRequestBehavior = behavior
            };
        }
    }
}
