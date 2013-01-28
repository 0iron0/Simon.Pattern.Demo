using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Builder
{
    public class FormDirector
    {
        private FormBuilderBase mBuilder;
        public FormDirector(FormBuilderBase builder)
        {
            this.mBuilder = builder;
        }

        public void Create(List<Field> fields)
        {
            foreach (Field field in fields)
            {
                try
                {
                    this.mBuilder.AddLabel(field.Name);
                    this.mBuilder.AddControl(field.Type);
                    this.mBuilder.AddNewLine();
                }
                catch { }
            }
            this.mBuilder.AddButton("submit");
        }
    }

    public abstract class FormBuilderBase
    {
        public abstract void AddLabel(string name);
        public abstract void AddControl(string type);
        public abstract void AddNewLine();
        public abstract void AddButton(string name);

        public abstract FormPage GetControl();
    }

    public class WebFormBuider :FormBuilderBase
    {
        private FormPage mFormPage;
        public WebFormBuider()
        {
            this.mFormPage = new FormPage();
        }

        public override void AddLabel(string name)
        {
            this.mFormPage.AddComponent(string.Format("Add a lable: {0}", name));
        }

        public override void AddControl(string type)
        {
            this.mFormPage.AddComponent(string.Format("Add a control: {0}", type));
        }

        public override void AddNewLine()
        {
            this.mFormPage.AddComponent(string.Format("Add a new line"));
        }

        public override void AddButton(string name)
        {
            this.mFormPage.AddComponent(string.Format("Add a button: {0}", name));
        }

        public override FormPage GetControl()
        {
            return this.mFormPage;
        }
    }

    public class FormPage
    {
        StringBuilder PageBuilder { get; set; }
        public FormPage()
        {
            this.PageBuilder = new StringBuilder(256);
        }

        public void AddComponent(string component)
        {
            this.PageBuilder.AppendLine(component);
        }

        public string GetPage()
        {
            return this.PageBuilder.ToString();
        }
    }

    public class Field
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
