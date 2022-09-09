using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityPayeeinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityPayeeinfoCreateModel : AopObject
    {
        /// <summary>
        /// 结算使用的收款账号。收款账号必须是支付宝的2088开头的账号。
        /// </summary>
        [XmlElement("payee_pid")]
        public string PayeePid { get; set; }

        /// <summary>
        /// 进件账号归属的资金结算请求模式，默认为请款模式 PERIOD 账期模式 CAPTURE 请款模式
        /// </summary>
        [XmlElement("payee_settle_mode")]
        public string PayeeSettleMode { get; set; }
    }
}
