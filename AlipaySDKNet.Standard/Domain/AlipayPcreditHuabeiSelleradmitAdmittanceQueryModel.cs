using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSelleradmitAdmittanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSelleradmitAdmittanceQueryModel : AopObject
    {
        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 合作机构的支付宝id
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 收款方的支付宝id
        /// </summary>
        [XmlElement("payee_alipay_user_id")]
        public string PayeeAlipayUserId { get; set; }

        /// <summary>
        /// 请求标识
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 准入查询场景
        /// </summary>
        [XmlElement("seller_admit_scene")]
        public string SellerAdmitScene { get; set; }

        /// <summary>
        /// 摊位id
        /// </summary>
        [XmlElement("stall_code")]
        public string StallCode { get; set; }

        /// <summary>
        /// 二级商户的id
        /// </summary>
        [XmlElement("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
