using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotvspGroupclearQueryResponse.
    /// </summary>
    public class AlipayOpenIotvspGroupclearQueryResponse : AopResponse
    {
        /// <summary>
        /// 接口成功时返回status字段
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
