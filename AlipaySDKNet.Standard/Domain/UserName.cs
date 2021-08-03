using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserName Data Structure.
    /// </summary>
    [Serializable]
    public class UserName : AopObject
    {
        /// <summary>
        /// User's first name
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// User's full name
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// User's last name
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// User's middle name
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }
    }
}
