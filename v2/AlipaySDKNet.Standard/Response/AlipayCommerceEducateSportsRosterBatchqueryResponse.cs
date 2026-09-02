using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsRosterBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsRosterBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 花名册列表
        /// </summary>
        [XmlElement("list")]
        public SportsRosterBatchQueryItem List { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
