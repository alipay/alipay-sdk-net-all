using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPaiProxyRedirectResponse.
    /// </summary>
    public class AlipayPaiProxyRedirectResponse : AopResponse
    {
        /// <summary>
        /// 测试返回数据，页面级接口此项没用
        /// </summary>
        [XmlElement("test_res")]
        public string TestRes { get; set; }
    }
}
