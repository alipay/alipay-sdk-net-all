using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LmModifySkuList Data Structure.
    /// </summary>
    [Serializable]
    public class LmModifySkuList : AopObject
    {
        /// <summary>
        /// 是否可售卖
        /// </summary>
        [XmlElement("can_sell")]
        public bool CanSell { get; set; }

        /// <summary>
        /// 积分
        /// </summary>
        [XmlElement("points")]
        public long Points { get; set; }

        /// <summary>
        /// 积分抵扣金额
        /// </summary>
        [XmlElement("points_amount")]
        public long PointsAmount { get; set; }

        /// <summary>
        /// 销售价格（分）
        /// </summary>
        [XmlElement("price_cent")]
        public long PriceCent { get; set; }

        /// <summary>
        /// 商品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
