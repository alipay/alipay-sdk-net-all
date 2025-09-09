using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDiscountDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDiscountDetailInfo : AopObject
    {
        /// <summary>
        /// 订单咨询返回的consultId，需透传到下单链路，下单会基于这个id做结果一致性校验
        /// </summary>
        [XmlElement("activity_consult_id")]
        public string ActivityConsultId { get; set; }

        /// <summary>
        /// sku优惠列表
        /// </summary>
        [XmlArray("item_consult_detail_info_list")]
        [XmlArrayItem("promo_item_consult_detail_info")]
        public List<PromoItemConsultDetailInfo> ItemConsultDetailInfoList { get; set; }

        /// <summary>
        /// 渠道优惠汇总列表
        /// </summary>
        [XmlArray("promo_amount_info_list")]
        [XmlArrayItem("promo_sum_info")]
        public List<PromoSumInfo> PromoAmountInfoList { get; set; }
    }
}
