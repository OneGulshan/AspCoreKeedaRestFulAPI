using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data.Command
{
    public class DeleteEmployeeCommand : IRequest<Employee>
    {
        public int Id { get; set; }
    }
}
