using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    internal class ProjectGroup
    {
        private string name;
        List<Member> members;

        public ProjectGroup(string name)
        {
            this.name = name;
            members = new List<Member>();
        }

        public void AddMember(string name)
        {
            Member newMember = new Member(name);
            members.Add(newMember);
        }

        public string GetInfo()
        {
            if (members.Count == 0)
            {
                return $"{name}";
            }
            else
            {
                string result = $"{name}:";
                foreach(Member member in members)
                {
                    result += $"\n{member.GetInfo()}";
                }

                return result;
            }
        }

    }
}
