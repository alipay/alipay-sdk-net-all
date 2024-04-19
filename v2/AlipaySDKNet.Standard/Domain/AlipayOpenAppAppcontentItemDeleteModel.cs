using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentItemDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppAppcontentItemDeleteModel : AopObject
    {
        /// <summary>
        /// 业务唯一ID；和商品ID任一必填一个
        /// </summary>
        [XmlElement("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 商品ID；和业务唯一ID任一必填一个
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }
    }
}
