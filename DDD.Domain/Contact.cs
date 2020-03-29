using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain
{
    public class Contact
    {
        public Contact(string name)
        {
            this.Name = name;
        }

        public Contact(string name, string displayName)
        {
            this.Name = name;
            this.DisplayName = displayName;
        }

        public string Name { get; private set; }
        public string DisplayName { get; private set; }
    }
}
