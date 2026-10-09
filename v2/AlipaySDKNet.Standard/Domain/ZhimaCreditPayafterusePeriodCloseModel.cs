using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafterusePeriodCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafterusePeriodCloseModel : AopObject
    {
        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        [XmlElement("auth_id")]
        public string AuthId { get; set; }

        /// <summary>
        /// 商户账期单号
        /// </summary>
        [XmlElement("out_period_no")]
        public string OutPeriodNo { get; set; }
    }
}
