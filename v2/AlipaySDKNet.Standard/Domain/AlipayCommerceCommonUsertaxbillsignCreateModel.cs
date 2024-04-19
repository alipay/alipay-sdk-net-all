using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonUsertaxbillsignCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonUsertaxbillsignCreateModel : AopObject
    {
        /// <summary>
        /// 淘客签约完成后的回跳地址
        /// </summary>
        [XmlElement("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 需要签约淘客的userId
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 需要签约淘客的openId
        /// </summary>
        [XmlElement("sign_user_open_id")]
        public string SignUserOpenId { get; set; }
    }
}
