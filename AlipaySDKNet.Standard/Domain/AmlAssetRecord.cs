using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AmlAssetRecord Data Structure.
    /// </summary>
    [Serializable]
    public class AmlAssetRecord : AopObject
    {
        /// <summary>
        /// 数据生效时间
        /// </summary>
        [XmlElement("active_date")]
        public string ActiveDate { get; set; }

        /// <summary>
        /// 名单或风险标签ID
        /// </summary>
        [XmlElement("lid")]
        public string Lid { get; set; }

        /// <summary>
        /// 客户ID
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 风险资产标签值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
