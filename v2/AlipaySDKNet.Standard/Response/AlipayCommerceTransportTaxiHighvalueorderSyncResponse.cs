using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiHighvalueorderSyncResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiHighvalueorderSyncResponse : AopResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
