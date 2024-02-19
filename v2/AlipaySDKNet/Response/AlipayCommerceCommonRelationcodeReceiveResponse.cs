using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonRelationcodeReceiveResponse.
    /// </summary>
    public class AlipayCommerceCommonRelationcodeReceiveResponse : AopResponse
    {
        /// <summary>
        /// 团长机构设定的绑定关系页面分享二维码
        /// </summary>
        [XmlElement("url_code")]
        public string UrlCode { get; set; }
    }
}
