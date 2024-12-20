using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierIcpregistrationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierIcpregistrationQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业ICP备案内容
        /// </summary>
        [XmlElement("data")]
        public EpICPRegistrationDataInfo Data { get; set; }
    }
}
