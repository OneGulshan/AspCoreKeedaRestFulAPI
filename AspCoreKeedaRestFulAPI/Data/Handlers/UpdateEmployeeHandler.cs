using AspCoreKeedaRestFulAPI.Data.Command;
using AspCoreKeedaRestFulAPI.Infrastructure;
using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepo _repo;

        public UpdateEmployeeHandler(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public async Task<Employee?> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _repo.GetEmployee(request.Id);
            if (employee == null) return default;

            employee.Name = request.Name;
            employee.City = request.City;
            return await _repo.UpdateEmployee(employee);
        }
    }
}
