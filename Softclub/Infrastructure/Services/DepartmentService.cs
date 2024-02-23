using Domain.Models;
namespace Infrastructure;

public class DepartamentService
{
 public List<Departament>  _departaments=new List<Departament>();
 
public List<Departament> GetDepartaments()
{
    return _departaments;
}
public void AddDepartaments(Departament departament)
{
_departaments.Add(departament);
}

}

