using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotManufacturerUrlModifyResponse.
    /// </summary>
    public class AlipayCommerceIotManufacturerUrlModifyResponse : AopResponse
    {
        /// <summary>
        /// 流水单号
        /// </summary>
        [XmlElement("flow_no")]
        public string FlowNo { get; set; }

        /// <summary>
        /// 流水状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
