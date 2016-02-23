# Was.JsonNetResult
Helper result for newtonsoft.

## What is included?

THe main class is JsonNetResult:

```c#
public class JsonNetResult : JsonResult
{
  ...
}
```

and extension metthod for controller:

```c#
public classs HomeController : Controller
{
    public ActionResult MyJson() 
    { 
         return this.JsonNetResult(new { isOk = true; }, null, null, JsonRequestBehavior.AllowGet);
            
    }
}
```
