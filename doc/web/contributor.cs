//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.0.3705.288
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by xsd, Version=1.0.3705.288.
//
using System.Xml.Serialization;


/// <remarks/>
[System.Xml.Serialization.XmlRootAttribute("contributors", Namespace="", IsNullable=false)]
public class Contributors {

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contributor")]
        public Contributor[] contributor;
}

/// <remarks/>
public class Contributor {

        public Contributor () {}

        /// <remarks/>
        public Name name;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("e-mail")]
        public string email;

        /// <remarks/>
        public string image;

        /// <remarks/>
        public string location;

        /// <remarks/>
        public string organization;

        /// <remarks/>
        public string description;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("task", IsNullable=false)]
        public string[] tasks;
}

/// <remarks/>
public class Name {

        public Name (string s)
        {
                string [] name = s.Split (' ');
                firstname = name [0];
                lastname = name [1];
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("first-name")]
        public string firstname;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-name")]
        public string lastname;

        public override string ToString ()
        {
                return firstname + " " + lastname;
        }
}
