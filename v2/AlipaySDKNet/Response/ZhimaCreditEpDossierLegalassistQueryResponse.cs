using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierLegalassistQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierLegalassistQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业司法协助内容
        /// </summary>
        [XmlElement("data")]
        public EpLegalAssistDataInfo Data { get; set; }
    }
}
