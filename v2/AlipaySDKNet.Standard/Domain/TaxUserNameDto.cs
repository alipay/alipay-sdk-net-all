using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaxUserNameDto Data Structure.
    /// </summary>
    [Serializable]
    public class TaxUserNameDto : AopObject
    {
        /// <summary>
        /// first_name
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The full name of the user.
        /// </summary>
        [XmlElement("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// The last name of the user.
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The middle name of the user.
        /// </summary>
        [XmlElement("middle_name")]
        public string MiddleName { get; set; }
    }
}
