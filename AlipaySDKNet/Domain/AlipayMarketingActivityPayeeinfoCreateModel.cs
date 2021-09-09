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
    }
}
