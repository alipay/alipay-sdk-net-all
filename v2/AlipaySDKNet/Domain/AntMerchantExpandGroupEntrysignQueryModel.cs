using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandGroupEntrysignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandGroupEntrysignQueryModel : AopObject
    {
        /// <summary>
        /// openid 是支付宝用户在应用维度下的唯一标识。 ● 支付宝用户访问小程序、网页移动应用、生活号等应用，会产生唯一的 openid。并且对于同一用户，不同应用的 openid 是不同的。 ● 例如，对于不同小程序，同一用户的 openid 不同；同理，对于不同的网页移动应用，同一用户的 openid 也是不同的。
        /// </summary>
        [XmlElement("entry_sign_open_id")]
        public string EntrySignOpenId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
