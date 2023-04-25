using DataAccessLayer;
using MediatR;

namespace AspCoreKeedaRestFulAPI.Data
{
    public class GetEmployeeListQuery :IRequest<List<Employee>>
    {
    }
}
