using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseWalletSignConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseWalletSignConsultModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
