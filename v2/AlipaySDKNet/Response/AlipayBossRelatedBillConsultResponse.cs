using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossRelatedBillConsultResponse.
    /// </summary>
    public class AlipayBossRelatedBillConsultResponse : AopResponse
    {
        /// <summary>
        /// 关联交易账单甄别结果
        /// </summary>
        [XmlElement("result_set")]
        public InterTradeBillConsultOpenApiResult ResultSet { get; set; }
    }
}
