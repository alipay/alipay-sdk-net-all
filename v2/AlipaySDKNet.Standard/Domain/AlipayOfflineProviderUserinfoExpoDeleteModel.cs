using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderUserinfoExpoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderUserinfoExpoDeleteModel : AopObject
    {
        /// <summary>
        /// 身份证号。可以传明文，也可以传身份证号的32位大写MD5值。尽量使用MD5值
        /// </summary>
        [XmlElement("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 活动最小单元ID
        /// </summary>
        [XmlElement("time_uuid")]
        public string TimeUuid { get; set; }
    }
}
