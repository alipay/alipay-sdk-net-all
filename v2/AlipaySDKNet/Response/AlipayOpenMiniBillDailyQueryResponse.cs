using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniBillDailyQueryResponse.
    /// </summary>
    public class AlipayOpenMiniBillDailyQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询返回的账单
        /// </summary>
        [XmlElement("response")]
        public CertBillDetail Response { get; set; }
    }
}
