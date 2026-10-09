using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialMerchantQueryModel : AopObject
    {
        /// <summary>
        /// 支付宝用户的openid。
        /// </summary>
        [XmlElement("login_open_id")]
        public string LoginOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("login_user_id")]
        public string LoginUserId { get; set; }

        /// <summary>
        /// 主账户openid。
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 主账户id。
        /// </summary>
        [XmlElement("owner_user_id")]
        public string OwnerUserId { get; set; }
    }
}
