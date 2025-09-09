using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierInvestQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierInvestQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业对外投资内容
        /// </summary>
        [XmlElement("data")]
        public EpInvestDataInfo Data { get; set; }
    }
}
