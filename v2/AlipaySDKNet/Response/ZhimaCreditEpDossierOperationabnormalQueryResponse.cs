using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierOperationabnormalQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierOperationabnormalQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业经营异常内容
        /// </summary>
        [XmlElement("data")]
        public EpOperationAbnormalDataInfo Data { get; set; }
    }
}
