using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIndustryPromoConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportIndustryPromoConsultModel : AopObject
    {
        /// <summary>
        /// 行业场景编码
        /// </summary>
        [XmlElement("industry_scene")]
        public string IndustryScene { get; set; }

        /// <summary>
        /// 支付宝open_id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单金额,单位：元，支持两位小数
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 合作方编码
        /// </summary>
        [XmlElement("partner_code")]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
