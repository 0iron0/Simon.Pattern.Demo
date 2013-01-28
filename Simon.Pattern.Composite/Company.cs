using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.Composite
{
    public abstract class Company
    {
        protected string mName;
        public Company(string name)
        {
            this.mName = name;
        }

        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }

    public class ConcreteCompany : Company
    {
        private List<Company> mChildCompanies = new List<Company>();
        public ConcreteCompany(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            this.mChildCompanies.Add(c);
        }

        public override void Remove(Company c)
        {
            this.mChildCompanies.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.mName);
            foreach (Company c in this.mChildCompanies)
            {
                c.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company c in this.mChildCompanies)
            {
                c.LineOfDuty();
            }
        }
    }

    public class HrDepartment : Company
    {
        public HrDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.mName);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 负责招聘员工", this.mName);
        }
    }

    public class FinanceDepartment : Company
    {
        public FinanceDepartment(string name)
            : base(name)
        { }

        public override void Add(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.mName);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 负责发工资", this.mName);
        }
    }
}
