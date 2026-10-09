using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmockNewinterfaceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmockNewinterfaceQueryModel : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("string_2")]
        public long String2 { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("string_un")]
        public string StringUn { get; set; }
    }
}
