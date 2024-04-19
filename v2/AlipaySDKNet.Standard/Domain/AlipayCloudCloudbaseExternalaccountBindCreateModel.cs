using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseExternalaccountBindCreateModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 预绑定ID
        /// </summary>
        [XmlElement("prebind_id")]
        public string PrebindId { get; set; }
    }
}
