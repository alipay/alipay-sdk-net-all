using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BsPlanBrandInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BsPlanBrandInfo : AopObject
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
