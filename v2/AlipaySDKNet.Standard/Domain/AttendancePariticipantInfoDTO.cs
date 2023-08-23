using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AttendancePariticipantInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AttendancePariticipantInfoDTO : AopObject
    {
        /// <summary>
        /// 主体补充参数
        /// </summary>
        [XmlElement("extend_params")]
        public ParticipantExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 授权主体名称(支付宝会员登录号类型必选)
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 主体Id
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("participant_id_type")]
        public string ParticipantIdType { get; set; }
    }
}
