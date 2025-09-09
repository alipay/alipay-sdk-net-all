using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflinePaysaasOrderCreateResponse.
    /// </summary>
    public class AlipayOfflinePaysaasOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 推单业务的唯一单号
        /// </summary>
        [XmlElement("isv_order_no")]
        public string IsvOrderNo { get; set; }
    }
}
