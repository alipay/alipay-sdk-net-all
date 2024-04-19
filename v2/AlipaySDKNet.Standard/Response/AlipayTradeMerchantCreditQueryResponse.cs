using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeMerchantCreditQueryResponse.
    /// </summary>
    public class AlipayTradeMerchantCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 卖家已经授权拆分给到买家的赊账额度,单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("granted_credit_quota")]
        public string GrantedCreditQuota { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [XmlElement("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 商家授权开通账期的卖家userid
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 当前最大信用额度,单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("total_credit_quota")]
        public string TotalCreditQuota { get; set; }
    }
}
