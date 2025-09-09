using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordertagPositionBindResponse.
    /// </summary>
    public class AlipayOpenSpNordertagPositionBindResponse : AopResponse
    {
        /// <summary>
        /// 绑定操作结果
        /// </summary>
        [XmlElement("bind_result")]
        public string BindResult { get; set; }
    }
}
