using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Facade
{
    /// <summary>
    /// Facade Pattern
    /// 将子系统的一组接口集成到一起的高层接口，以提供一致的操作接口
    /// 优点：对外提供统一的接口，从而使子系统更容易维护
    /// 例子：对于数据操作的类有SqlConnection/SqlCommand/SqlAdapter等等
    /// 将这些对象的封装起来，可以提供更加统一，简洁的调用方式
    /// </summary>
    public class FacadeDemo
    {
        public static void Run()
        {
            using (DbOperation operation = new DbOperation("ConnectionString"))
            {
                operation.ExcuteSql("Select * From TableName");
            }
        }
    }
}
