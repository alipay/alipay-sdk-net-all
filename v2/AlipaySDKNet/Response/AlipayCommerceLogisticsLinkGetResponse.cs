using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsLinkGetResponse.
    /// </summary>
    public class AlipayCommerceLogisticsLinkGetResponse : AopResponse
    {
        /// <summary>
        /// 根据请求logistics_wallet_open返回
        /// </summary>
        [XmlElement("logistics_biz_scene_action")]
        public string LogisticsBizSceneAction { get; set; }

        /// <summary>
        /// 标识返回的链接是否加密，true-加密、false-不加密
        /// </summary>
        [XmlElement("logistics_link_encryption")]
        public bool LogisticsLinkEncryption { get; set; }

        /// <summary>
        /// 跳转支付宝-我的快递业务场景执行链接
        /// </summary>
        [XmlElement("logistics_link_url")]
        public string LogisticsLinkUrl { get; set; }
    }
}
