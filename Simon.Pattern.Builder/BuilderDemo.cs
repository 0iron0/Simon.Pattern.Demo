using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Builder
{
    /// <summary>
    /// Builder Pattern
    /// 将复杂对象的建造和表示分离，使同样的创建过程可以创建出不同的表示
    /// 下例子中同样的建造过程，还可以建造出WinForm的界面
    /// </summary>
    public class BuilderDemo
    {
        public static void Run()
        {
            List<Field> fields = new List<Field>
            { 
                new Field{Name="name", Type="TextBox"},
                new Field{Name="value", Type="TextBox"}
            };
            FormBuilderBase builder = new WebFormBuider();
            FormDirector director = new FormDirector(builder);
            director.Create(fields);
            FormPage page = builder.GetControl();
            Console.WriteLine(page.GetPage());
        }
    }
}
