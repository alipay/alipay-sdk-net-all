using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RareNameInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RareNameInfo : AopObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remarks")]
        public string Remarks { get; set; }
    }
}
