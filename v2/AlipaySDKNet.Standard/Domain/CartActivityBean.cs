using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CartActivityBean Data Structure.
    /// </summary>
    [Serializable]
    public class CartActivityBean : AopObject
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 优惠限购数量
        /// </summary>
        [XmlElement("limit_cnt")]
        public long LimitCnt { get; set; }

        /// <summary>
        /// 商品原价【人民币】
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 原价SkuId
        /// </summary>
        [XmlElement("original_sku_id")]
        public string OriginalSkuId { get; set; }
    }
}
