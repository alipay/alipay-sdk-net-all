using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRiskSummaryCheckModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRiskSummaryCheckModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码或营业执照注册号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
