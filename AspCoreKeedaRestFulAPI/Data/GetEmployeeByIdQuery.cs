using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data
{
    public class GetEmployeeByIdQuery : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
