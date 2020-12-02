using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpBlueseaactivityCreateResponse.
    /// </summary>
    public class AlipayOpenSpBlueseaactivityCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单Id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
