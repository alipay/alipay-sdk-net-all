using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinTradeQueryResponse : AopResponse
    {
        /// <summary>
        /// biz_result
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
