using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSafeboxAgreementSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSafeboxAgreementSignModel : AopObject
    {
        /// <summary>
        /// 用户（UserId）在应用（AppId）下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
