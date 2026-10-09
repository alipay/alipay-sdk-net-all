using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAuthBindingGetResponse.
    /// </summary>
    public class AlipayCommerceTransportAuthBindingGetResponse : AopResponse
    {
        /// <summary>
        /// 授权状态数据。当接口调用成功时，需要返回该字段。
        /// </summary>
        [XmlElement("data")]
        public TransportAuthStatusData Data { get; set; }
    }
}
