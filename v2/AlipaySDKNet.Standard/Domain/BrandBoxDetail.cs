using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandBoxDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BrandBoxDetail : AopObject
    {
        /// <summary>
        /// 品牌box提报信息
        /// </summary>
        [XmlElement("detail")]
        public BoxDetail Detail { get; set; }

        /// <summary>
        /// 品牌box提报key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
