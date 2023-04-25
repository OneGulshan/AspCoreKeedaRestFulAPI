using AspCoreKeedaRestFulAPI.Infrastructure;
using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data.Handlers
{
    public class GetEmployeeHandlers : IRequestHandler<GetEmployeeByIdQuery, Employee>
    {
        private readonly IEmployeeRepo _repo;

        public GetEmployeeHandlers(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public async Task<Employee> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repo.GetEmployee(request.Id);
        }
    }
}
