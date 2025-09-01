using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourUserinfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourUserinfoQueryModel : AopObject
    {
        /// <summary>
        /// 会话信息
        /// </summary>
        [XmlElement("code_token")]
        public string CodeToken { get; set; }

        /// <summary>
        /// 新商户建议使用open_id替代该字段。对于新商户，user_id字段未来计划逐步回收，存量商户可继续使用。如使用open_id，请确认 应用-开发配置-openid配置管理 已启用。无该配置项，可查看openid配置申请：<a href="https://opendocs.alipay.com/mini/0ai9ok?pathHash=de631c06">alipay.commerce.transport.tour.userinfo.query</a>。 
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 文旅景点id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。 
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
