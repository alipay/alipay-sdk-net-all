using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserfordeviceCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserfordeviceCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作流水号
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
