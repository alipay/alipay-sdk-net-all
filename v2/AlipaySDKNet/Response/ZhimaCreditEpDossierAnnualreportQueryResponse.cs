using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpDossierAnnualreportQueryResponse.
    /// </summary>
    public class ZhimaCreditEpDossierAnnualreportQueryResponse : AopResponse
    {
        /// <summary>
        /// 数据结果
        /// </summary>
        [XmlElement("data")]
        public ZmepAnnualReportDataInfo Data { get; set; }
    }
}
