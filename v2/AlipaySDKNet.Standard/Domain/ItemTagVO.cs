using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemTagVO Data Structure.
    /// </summary>
    [Serializable]
    public class ItemTagVO : AopObject
    {
        /// <summary>
        /// 商品标签ID，例如：极速退款 TI00290152;晚发必赔 TI00311310
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("tag_value")]
        public string TagValue { get; set; }
    }
}
