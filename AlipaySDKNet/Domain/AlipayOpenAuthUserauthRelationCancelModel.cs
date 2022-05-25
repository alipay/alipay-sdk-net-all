using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAuthUserauthRelationCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAuthUserauthRelationCancelModel : AopObject
    {
        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
