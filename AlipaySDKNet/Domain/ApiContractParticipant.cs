using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApiContractParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class ApiContractParticipant : AopObject
    {
        /// <summary>
        /// 业务主体id，比如淘宝id
        /// </summary>
        [XmlElement("biz_principal_id")]
        public string BizPrincipalId { get; set; }

        /// <summary>
        /// 业务主体类型
        /// </summary>
        [XmlElement("biz_principal_type")]
        public string BizPrincipalType { get; set; }

        /// <summary>
        /// offer、acceptor
        /// </summary>
        [XmlElement("participant_type")]
        public string ParticipantType { get; set; }

        /// <summary>
        /// 主体id，一般是user_id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 主体类型B/C
        /// </summary>
        [XmlElement("principal_type")]
        public string PrincipalType { get; set; }
    }
}
