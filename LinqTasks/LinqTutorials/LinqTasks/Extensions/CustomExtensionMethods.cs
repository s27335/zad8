using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps.Where(x1 => emps.Any(x2 => x2.Mgr == x1)).OrderBy(x1 => x1.Ename).ThenByDescending(x1 => x1.Salary);
    }
}