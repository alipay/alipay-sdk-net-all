using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcMiniappPageurlQueryResponse.
    /// </summary>
    public class AlipayCommerceEcMiniappPageurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 页面类型，传需要跳转到具体位置的页面类型，如企业码小程序列表页，或者三方小程序某个页面
        /// </summary>
        [XmlElement("page_type")]
        public string PageType { get; set; }

        /// <summary>
        /// 页面跳链，默认有效期为10分钟
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }
    }
}
