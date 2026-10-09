using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonUsertaxbillsignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonUsertaxbillsignQueryModel : AopObject
    {
        /// <summary>
        /// 淘客的userId
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 淘客的openId
        /// </summary>
        [XmlElement("sign_user_open_id")]
        public string SignUserOpenId { get; set; }
    }
}
