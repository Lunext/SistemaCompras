

using Compras.Application.Features.Department.Shared;

namespace Compras.Application.Features.Department.Queries.GetDepartmentDetails;

public class DepartmentDetailsDto: BaseDepartment
{
    public int Id { get; set;}
    public DateTime? DateCreated { get; set;}
    public DateTime? DateModified { get; set;}

}
