using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardSettleaccountSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardSettleaccountSaveModel : AopObject
    {
        /// <summary>
        /// 结算收款的支付宝账号，是登录账号，非pid
        /// </summary>
        [XmlElement("settle_alipay_logon_id")]
        public string SettleAlipayLogonId { get; set; }
    }
}
