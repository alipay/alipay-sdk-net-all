using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncTaxIitQueryResponse.
    /// </summary>
    public class AlipayBossFncTaxIitQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果集
        /// </summary>
        [XmlElement("result_set")]
        public IitBizDetailBillQueryPageResultOpenApiDTO ResultSet { get; set; }
    }
}
