using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacepayCloseResponse.
    /// </summary>
    public class AlipayCommerceEducateFacepayCloseResponse : AopResponse
    {
        /// <summary>
        /// 关闭申请执行结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
