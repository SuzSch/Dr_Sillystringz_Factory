using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        List<Engineer> engineers = _db.Engineers.ToList();
        List<Machine> machines = _db.Machines.ToList();

        return View((engineers, machines));
    }
}
