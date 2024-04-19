using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAuthorizeUniApplyResponse.
    /// </summary>
    public class AlipayFundAuthorizeUniApplyResponse : AopResponse
    {
        /// <summary>
        /// 授权跳转链接
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
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品业务码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
