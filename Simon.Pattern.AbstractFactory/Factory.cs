using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simon.Pattern.AbstractFactory
{
    public abstract class FactoryBase
    {
        public abstract UserBase CreateUser(string name);
        public abstract DepartmentBase CreateDepartment();
    }

    public abstract class UserBase
    {
        public abstract string GetName();
    }

    public abstract class DepartmentBase
    {
        public abstract void AddUser(UserBase u);
        public abstract UserBase GetUser(string name);
    }

    public class User : UserBase
    {
        private string mName { get; set; }

        public User(string name)
        {
            this.mName = name;
        }

        public override string GetName()
        {
            return this.mName;
        }
    }

    public class Department : DepartmentBase
    {
        private List<UserBase> Users = new List<UserBase>();

        public override void AddUser(UserBase u)
        {
            Users.Add(u);
        }

        public override UserBase GetUser(string name)
        {
            return Users.Find((user)=>user.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }

    public class Factory : FactoryBase
    {


        public override UserBase CreateUser(string name)
        {
            return new User(name);
        }

        public override DepartmentBase CreateDepartment()
        {
            return new Department();
        }
    }
}
