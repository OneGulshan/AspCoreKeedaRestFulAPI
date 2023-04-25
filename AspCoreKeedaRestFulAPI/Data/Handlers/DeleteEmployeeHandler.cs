using AspCoreKeedaRestFulAPI.Data.Command;
using AspCoreKeedaRestFulAPI.Infrastructure;
using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepo _repo;

        public DeleteEmployeeHandler(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public async Task<Employee?> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repo.GetEmployee(request.Id);
            if (employee == null) return default;
            return await _repo.DeleteEmployee(request.Id);
        }
    }
}
