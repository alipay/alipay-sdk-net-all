using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradeLoanstatusAdmitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeLoanstatusAdmitQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝Id,无需脱敏 
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝Id,无需脱敏
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
