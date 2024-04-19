using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossRelatedCompanyConsultResponse.
    /// </summary>
    public class AlipayBossRelatedCompanyConsultResponse : AopResponse
    {
        /// <summary>
        /// 关联交易公司甄别结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradeCompanyConsultOpenApiResult ResultSet { get; set; }
    }
}
