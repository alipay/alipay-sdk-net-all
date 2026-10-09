using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseIdeAccountadminAuthModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseIdeAccountadminAuthModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授权绑定ID
        /// </summary>
        [XmlElement("auth_bind_id")]
        public string AuthBindId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [XmlElement("biz_env_id")]
        public string BizEnvId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
