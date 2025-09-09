using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardSettleaccountusedQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardSettleaccountusedQueryResponse : AopResponse
    {
        /// <summary>
        /// 结算收款的支付宝账号，登录账号，非pid
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }

        /// <summary>
        /// 是否支持代扣
        /// </summary>
        [XmlElement("support_deduct")]
        public bool SupportDeduct { get; set; }
    }
}
