using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtcSellerconfigQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportEtcSellerconfigQueryResponse : AopResponse
    {
        /// <summary>
        /// 查询得到的发行方静态信息（图片、文字等配置信息）
        /// </summary>
        [XmlElement("query_results")]
        public string QueryResults { get; set; }
    }
}
