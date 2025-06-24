using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCounterpartyVerificationQueryResponse.
    /// </summary>
    public class ZhimaCreditEpCounterpartyVerificationQueryResponse : AopResponse
    {
        /// <summary>
        /// 企业查询key，入参原样返回
        /// </summary>
        [XmlElement("company_key")]
        public string CompanyKey { get; set; }

        /// <summary>
        /// 交易对手核验结果
        /// </summary>
        [XmlElement("data")]
        public CounterpartyVerifyResult Data { get; set; }
    }
}
