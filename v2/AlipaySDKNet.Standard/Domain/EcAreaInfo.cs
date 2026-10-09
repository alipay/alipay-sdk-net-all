using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcAreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcAreaInfo : AopObject
    {
        /// <summary>
        /// 行政编码
        /// </summary>
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 行政区划名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级行政编码
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
