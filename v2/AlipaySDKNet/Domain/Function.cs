using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Function Data Structure.
    /// </summary>
    [Serializable]
    public class Function : AopObject
    {
        /// <summary>
        /// 功能点id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 功能点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
