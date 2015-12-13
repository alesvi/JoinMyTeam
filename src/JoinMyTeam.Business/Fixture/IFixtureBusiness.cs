using System;

namespace JoinMyTeam.Business.Fixture
{
    public interface IFixtureBusiness
    {
        Domain.Fixture Create(Domain.Fixture fixture);
        Domain.Fixture Update(Domain.Fixture fixture);
        void Delete(Guid id);
        Domain.Fixture Get(Guid id);
        void AddAttendee(Domain.Fixture fixture, Domain.Attendee attendee);
        void RemoveAttendee(Domain.Fixture fixture);
    }
}
