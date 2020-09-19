using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinFinanceArQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinFinanceArQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [XmlElement("biz_result")]
        public BizResult BizResult { get; set; }
    }
}
