using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceWaterUsertaskSendResponse.
    /// </summary>
    public class AlipayCommerceWaterUsertaskSendResponse : AopResponse
    {
        /// <summary>
        /// 上报是否成功
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
