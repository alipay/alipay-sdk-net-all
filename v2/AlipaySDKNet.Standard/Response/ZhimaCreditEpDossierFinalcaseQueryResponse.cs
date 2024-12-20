using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierFinalcaseQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierFinalcaseQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业终本案件内容
        /// </summary>
        [XmlElement("data")]
        public EpFinalCaseDataInfo Data { get; set; }
    }
}
