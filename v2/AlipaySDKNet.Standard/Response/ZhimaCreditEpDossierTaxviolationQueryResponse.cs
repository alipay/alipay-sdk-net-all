using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierTaxviolationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierTaxviolationQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmepTaxViolationDataInfo Data { get; set; }
    }
}
