using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSceneUserQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateSceneUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 校园一脸通行开通状态。OPEN：开通，CLOSE：关闭
        /// </summary>
        [XmlElement("open_status")]
        public string OpenStatus { get; set; }
    }
}
