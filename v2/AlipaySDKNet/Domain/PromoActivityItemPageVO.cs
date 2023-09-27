using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityItemPageVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityItemPageVO : AopObject
    {
        /// <summary>
        /// 优惠ID
        /// </summary>
        [XmlElement("discount_id")]
        public string DiscountId { get; set; }

        /// <summary>
        /// 是否是线上版本SPU：true为线上版本数据，false为最新版本数据
        /// </summary>
        [XmlElement("is_online")]
        public bool IsOnline { get; set; }

        /// <summary>
        /// 支付宝平台侧ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
