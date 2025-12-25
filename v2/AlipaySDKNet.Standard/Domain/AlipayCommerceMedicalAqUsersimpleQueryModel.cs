using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalAqUsersimpleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalAqUsersimpleQueryModel : AopObject
    {
        /// <summary>
        /// 用户当前2088
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用户当前2089
        /// </summary>
        [XmlElement("aq_user_id")]
        public string AqUserId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }
    }
}
