using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoApplycancelCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateInfoApplycancelCertifyModel : AopObject
    {
        /// <summary>
        /// 取消原因编码
        /// </summary>
        [XmlElement("cause_code")]
        public string CauseCode { get; set; }

        /// <summary>
        /// 取消原因描述
        /// </summary>
        [XmlElement("cause_msg")]
        public string CauseMsg { get; set; }

        /// <summary>
        /// 扩展信息json格式字符串
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 参赛者id
        /// </summary>
        [XmlElement("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }
    }
}
