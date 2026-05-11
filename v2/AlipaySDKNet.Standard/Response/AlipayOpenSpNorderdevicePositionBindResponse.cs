using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNorderdevicePositionBindResponse.
    /// </summary>
    public class AlipayOpenSpNorderdevicePositionBindResponse : AopResponse
    {
        /// <summary>
        /// 绑定结果
        /// </summary>
        [XmlElement("bind_result")]
        public string BindResult { get; set; }
    }
}
