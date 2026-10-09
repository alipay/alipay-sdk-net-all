using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ConsultParams Data Structure.
    /// </summary>
    [Serializable]
    public class ConsultParams : AopObject
    {
        /// <summary>
        /// 集团havana ID
        /// </summary>
        [XmlElement("another_hid")]
        public string AnotherHid { get; set; }
    }
}
