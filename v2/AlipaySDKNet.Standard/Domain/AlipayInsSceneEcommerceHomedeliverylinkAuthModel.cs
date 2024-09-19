using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceHomedeliverylinkAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceHomedeliverylinkAuthModel : AopObject
    {
        /// <summary>
        /// 买家联系地址
        /// </summary>
        [XmlElement("buyer_contact_address")]
        public LogisticsContactAddressDTO BuyerContactAddress { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order_dto")]
        public EcomOrderDTO OrderDto { get; set; }

        /// <summary>
        /// session过期时间
        /// </summary>
        [XmlElement("out_session_expiration")]
        public string OutSessionExpiration { get; set; }

        /// <summary>
        /// sessionId 外部的token
        /// </summary>
        [XmlElement("out_session_id")]
        public string OutSessionId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 订单逆向状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 关联保单号
        /// </summary>
        [XmlElement("related_policy_no")]
        public string RelatedPolicyNo { get; set; }

        /// <summary>
        /// 卖家同意退货时间
        /// </summary>
        [XmlElement("seller_agree_refund_time")]
        public string SellerAgreeRefundTime { get; set; }

        /// <summary>
        /// 卖家联系地址
        /// </summary>
        [XmlElement("seller_contact_address")]
        public LogisticsContactAddressDTO SellerContactAddress { get; set; }

        /// <summary>
        /// 客户端渠道
        /// </summary>
        [XmlElement("user_client")]
        public string UserClient { get; set; }
    }
}
