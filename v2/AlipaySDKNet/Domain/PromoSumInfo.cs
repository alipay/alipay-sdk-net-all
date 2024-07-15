using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoSumInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PromoSumInfo : AopObject
    {
        /// <summary>
        /// 商品优惠类型包括： ANT_MEMBER : 会员积分 CONSUME_GOLD：消费金
        /// </summary>
        [XmlElement("sale_promo_type")]
        public string SalePromoType { get; set; }

        /// <summary>
        /// 订单需要的总积分数
        /// </summary>
        [XmlElement("total_point_amount")]
        public string TotalPointAmount { get; set; }
    }
}
