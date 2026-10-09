using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGfcenterBanklogtransferCreateResponse.
    /// </summary>
    public class AlipayBossFncGfcenterBanklogtransferCreateResponse : AopResponse
    {
        /// <summary>
        /// 银行流水认领返回结果
        /// </summary>
        [XmlElement("result_set")]
        public JsonOpenApiVO ResultSet { get; set; }
    }
}
