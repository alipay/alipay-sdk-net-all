using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerPncCloseResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerPncCloseResponse : AopResponse
    {
        /// <summary>
        /// 关闭结果
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
