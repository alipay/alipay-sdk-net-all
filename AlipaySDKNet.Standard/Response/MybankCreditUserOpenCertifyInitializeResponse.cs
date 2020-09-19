using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankCreditUserOpenCertifyInitializeResponse.
    /// </summary>
    public class MybankCreditUserOpenCertifyInitializeResponse : AopResponse
    {
        /// <summary>
        /// 本次申请操作的唯一标识，商户需要记录，后续的操作都需要用到
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
