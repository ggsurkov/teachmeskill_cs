using System;
using System.ComponentModel;

namespace Lib
{

    public class AppInfo
    {
        public static string[] GetUserRilesList()
        {
            string[] UserRoles = { "Admin", "WebSecurity", "Support", "Worker" };
            return UserRoles;
        }
        public static bool CheckAccessLevelForSecurityFunctionality(int accessLevel) 
        { 
            if (accessLevel < 2)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Access denied! Please ask your administrator");
                return false; 
            }
        }
    }

    public class User
    {
        public string Name { get; set; }
        private string Pass { get; set; }
        public int _accessLevel;
        public int AccessLevel
        {
            get { return _accessLevel; }
        }


        public void SetPass(string pass)
        {
            if (AppInfo.CheckAccessLevelForSecurityFunctionality(AccessLevel))
            {
                Pass = pass;
            }
        }

        public virtual string GetInfo()
        {
            return $"My name is {Name}";
        }

        public int GetAccessLevel()
        {
            return AccessLevel;
        }
    }

    public class Admin : User
    {
        private int _accessLevel = 0;
        public int AccessLevel
        {
            get { return _accessLevel; }
        }

        public dynamic CreateUserByNameAndAccessLevel(string name, int accessLevel)
        {
            switch (accessLevel)
            {
                case 0:
                    Admin newAdmin = new Admin { Name = name };
                    newAdmin.SetPass(GetRandomizePass());

                    return newAdmin;
                case 1:
                    WebSecurity newWebSecurity = new WebSecurity { Name = name, _accessLevel = accessLevel };
                    newWebSecurity.SetPass(GetRandomizePass());

                    return newWebSecurity;
                case 2:
                    Support newSupport = new Support { Name = name, _accessLevel = accessLevel };
                    newSupport.SetPass(GetRandomizePass());

                    return newSupport;
                case 3:
                    Worker newUser = new Worker { Name = name, _accessLevel = accessLevel };
                    newUser.SetPass(GetRandomizePass());

                    return newUser;
                default:
                    return new User { Name = name };
            }
        }

        private string GetRandomizePass()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 15)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }

    public class WebSecurity : User
    {
        private int _accessLevel = 1;
        public int AccessLevel
        {
            get { return _accessLevel; }
        }

        public override string GetInfo()
        {
            Console.WriteLine($"My name is {base.Name}");
            return $"My name is {Name}";
        }

        public void GetInfoByParam(User user)
        {
            Console.WriteLine($"User name is {user.Name}. User Role is {GetUserRoleByAccessLevel(user.GetAccessLevel())}");
        }

        private string GetUserRoleByAccessLevel(int accessLevel)
        {
            return AppInfo.GetUserRilesList()[accessLevel];
        }
    }

    public class Support : User
    {
        private int _accessLevel = 2;
        public int AccessLevel
        {
            get { return _accessLevel; }
        }
        public User CurrentAcceptor { get; set; }

        public void SetCurrentAcceptor(User user)
        {
            CurrentAcceptor = user;
            Console.WriteLine($"{Name} will take your issue, please wait");
        }
    }

    public class Worker : User
    {
        private int _accessLevel = 3;
        public int AccessLevel
        {
            get { return _accessLevel; }
        }
        public string CurrentTask { get; set; }

        public void GetCurrentTask()
        {
            if (CurrentTask == null)
            {
                Console.WriteLine($"I don't work");
            }
            else
            {
                Console.WriteLine($"At now I working on {CurrentTask}");
            }
            
        }
        public void SetNewTask(string taskName)
        {
            CurrentTask = taskName;
            GetCurrentTask();
        }

        public void FinishCurrentTask()
        {
            Console.WriteLine($"I finished task: {CurrentTask}");
            CurrentTask = null;
        }
    }
}