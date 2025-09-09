using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAuthorizeUniModifyResponse.
    /// </summary>
    public class AlipayFundAuthorizeUniModifyResponse : AopResponse
    {
        /// <summary>
        /// 授权资产切换跳转链接
        /// </summary>
        [XmlElement("authorize_link")]
        public string AuthorizeLink { get; set; }

        /// <summary>
        /// 授权跳转类型
        /// </summary>
        [XmlElement("authorize_link_type")]
        public string AuthorizeLinkType { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
