using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpEvaluationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpEvaluationQueryModel : AopObject
    {
        /// <summary>
        /// 渠道码,联系bd分配
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 企业证件号，来自工商信息，优先取统一社会代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }
    }
}
