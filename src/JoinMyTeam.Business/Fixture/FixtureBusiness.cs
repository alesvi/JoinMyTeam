using System;
using JoinMyTeam.Domain;

namespace JoinMyTeam.Business.Fixture
{
    public class FixtureBusiness : IFixtureBusiness
    {
        public void AddAttendee(Domain.Fixture fixture, Attendee attendee)
        {
            throw new NotImplementedException();
        }

        public Domain.Fixture Create(Domain.Fixture fixture)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Domain.Fixture Get(Guid id)
        {
            var fixture = new Domain.Fixture() { Id = id, Where = "Test location" };

            return fixture;
        }

        public void RemoveAttendee(Domain.Fixture fixture)
        {
            throw new NotImplementedException();
        }

        public Domain.Fixture Update(Domain.Fixture fixture)
        {
            throw new NotImplementedException();
        }
    }
}
