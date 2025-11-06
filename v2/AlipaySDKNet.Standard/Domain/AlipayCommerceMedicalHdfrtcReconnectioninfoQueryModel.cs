using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfrtcReconnectioninfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfrtcReconnectioninfoQueryModel : AopObject
    {
        /// <summary>
        /// 角色类型 Space:医生 Patient:患者
        /// </summary>
        [XmlElement("role")]
        public string Role { get; set; }

        /// <summary>
        /// 医生空间ID
        /// </summary>
        [XmlElement("space_id")]
        public long SpaceId { get; set; }

        /// <summary>
        /// 好大夫侧用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
