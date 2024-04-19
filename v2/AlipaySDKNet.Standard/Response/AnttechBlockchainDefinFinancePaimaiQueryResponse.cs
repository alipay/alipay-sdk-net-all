using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinFinancePaimaiQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinFinancePaimaiQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
