using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalMemberBenefitQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalMemberBenefitQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益订单ID
        /// </summary>
        [XmlElement("benefit_order_id")]
        public string BenefitOrderId { get; set; }

        /// <summary>
        /// 权益优惠列表
        /// </summary>
        [XmlArray("discount_info_list")]
        [XmlArrayItem("benefit_discount_info_d_t_o")]
        public List<BenefitDiscountInfoDTO> DiscountInfoList { get; set; }

        /// <summary>
        /// 权益优惠类型   - voucher：券优惠  - exchange：0元兑换
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 会员价 单位：元
        /// </summary>
        [XmlElement("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 是否有会员资格：true-有；false-无
        /// </summary>
        [XmlElement("membership")]
        public bool Membership { get; set; }

        /// <summary>
        /// 商品原价：元
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }
    }
}
