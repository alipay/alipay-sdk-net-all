using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdSubaccountBalanceQueryResponse.
    /// </summary>
    public class AlipayBossProdSubaccountBalanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 子户余额信息
        /// </summary>
        [XmlElement("result_set")]
        public SubAccountBalanceOpenApiDTO ResultSet { get; set; }
    }
}
