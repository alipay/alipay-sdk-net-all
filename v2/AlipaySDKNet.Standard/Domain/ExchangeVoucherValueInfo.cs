using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExchangeVoucherValueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeVoucherValueInfo : AopObject
    {
        /// <summary>
        /// 兑换券本次变更的次数
        /// </summary>
        [XmlElement("change_count")]
        public long ChangeCount { get; set; }

        /// <summary>
        /// 兑换券可兑换的商品图片
        /// </summary>
        [XmlElement("product_img_url")]
        public string ProductImgUrl { get; set; }

        /// <summary>
        /// 兑换券可兑换的商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 兑换券剩余还可兑换的次数
        /// </summary>
        [XmlElement("remain_count")]
        public long RemainCount { get; set; }

        /// <summary>
        /// 兑换券可兑换的总次数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 兑换券已兑换的次数
        /// </summary>
        [XmlElement("used_count")]
        public long UsedCount { get; set; }
    }
}
