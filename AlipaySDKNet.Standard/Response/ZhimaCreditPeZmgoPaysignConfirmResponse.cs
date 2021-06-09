using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeZmgoPaysignConfirmResponse.
    /// </summary>
    public class ZhimaCreditPeZmgoPaysignConfirmResponse : AopResponse
    {
        /// <summary>
        /// 协议单号
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }
    }
}
