using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantMrchsurpActivitysignupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantMrchsurpActivitysignupCreateModel : AopObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 用户在客户端操作的umidToken，用户安全风控的校验
        /// </summary>
        [XmlElement("umid_token")]
        public string UmidToken { get; set; }

        /// <summary>
        /// 报名活动的用户ID，蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
