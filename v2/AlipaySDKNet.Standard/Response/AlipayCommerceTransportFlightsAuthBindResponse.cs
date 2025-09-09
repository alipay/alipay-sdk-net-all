using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportFlightsAuthBindResponse.
    /// </summary>
    public class AlipayCommerceTransportFlightsAuthBindResponse : AopResponse
    {
        /// <summary>
        /// 外部业务号，唯一标志本次请求
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
