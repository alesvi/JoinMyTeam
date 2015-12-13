using Microsoft.AspNet.Mvc;
using System;
using JoinMyTeam.Domain;
using JoinMyTeam.Business.Fixture;

namespace JoinMyTeam.Web.Controllers
{
    public class FixtureController : Controller
    {
        private IFixtureBusiness _fixtureBusiness;

        public FixtureController(IFixtureBusiness fixtureBusiness)
        {
            _fixtureBusiness = fixtureBusiness;
        }

        public IActionResult Get(Guid id)
        {
            var fixture = _fixtureBusiness.Get(id);

            return View(fixture);
        }        
    }
}
