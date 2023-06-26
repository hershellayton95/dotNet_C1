using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMainApplication.Model
{
    public class MyClass
    {
        private string privateMember = "private";
        protected string protectedMember = "protected";
        internal string internalMember = "internal";
        public string publicMember = "public";

        public string GetPrivateMember () { return privateMember; }
        public string GetProtectedMember() {  return protectedMember; }
        public string GetIinternalMember() { return internalMember; }
        public string GetPublicMember() { return publicMember; }

    }
}
