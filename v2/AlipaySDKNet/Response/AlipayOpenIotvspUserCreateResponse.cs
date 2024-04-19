using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作流水号，ISV需要记录，后续调用组件...
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
