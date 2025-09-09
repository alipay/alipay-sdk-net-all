using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DoctorMsgContent Data Structure.
    /// </summary>
    [Serializable]
    public class DoctorMsgContent : AopObject
    {
        /// <summary>
        /// 外部医生ID
        /// </summary>
        [XmlElement("ext_doctor_id")]
        public string ExtDoctorId { get; set; }

        /// <summary>
        /// 外部平台编码，由支付宝分配给isv
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 资质核验状态 通过:pass 不通过:rejected 待人工确认:uncertain
        /// </summary>
        [XmlElement("qualification_status")]
        public string QualificationStatus { get; set; }

        /// <summary>
        /// 资质核验不通过原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 时间戳，单位：毫秒
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
