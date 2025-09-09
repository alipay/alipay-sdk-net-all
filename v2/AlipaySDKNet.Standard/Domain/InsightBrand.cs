using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsightBrand Data Structure.
    /// </summary>
    [Serializable]
    public class InsightBrand : AopObject
    {
        /// <summary>
        /// 品牌 CODE
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
