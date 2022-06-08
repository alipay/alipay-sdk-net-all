using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspUserwithlabelCreateResponse.
    /// </summary>
    public class AlipayOpenIotvspUserwithlabelCreateResponse : AopResponse
    {
        /// <summary>
        /// 操作流水号，ISV需要记录，后续调用组件等操作需要用到
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
