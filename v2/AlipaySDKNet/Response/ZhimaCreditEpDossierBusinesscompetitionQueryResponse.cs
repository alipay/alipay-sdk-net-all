using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierBusinesscompetitionQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierBusinesscompetitionQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业业务竞争内容
        /// </summary>
        [XmlElement("data")]
        public EpBusinessCompetitionDataInfo Data { get; set; }
    }
}
