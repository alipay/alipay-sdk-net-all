using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceYuntaskTaxbillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceYuntaskTaxbillCreateModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签约用户
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }
    }
}
