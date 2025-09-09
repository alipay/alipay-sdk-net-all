using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformPlusRegisterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformPlusRegisterInfo : AopObject
    {
        /// <summary>
        /// 核销地址
        /// </summary>
        [XmlElement("write_off_address")]
        public string WriteOffAddress { get; set; }

        /// <summary>
        /// 核销码
        /// </summary>
        [XmlElement("write_off_code")]
        public string WriteOffCode { get; set; }

        /// <summary>
        /// 核销医生
        /// </summary>
        [XmlElement("write_off_doctor")]
        public string WriteOffDoctor { get; set; }

        /// <summary>
        /// 核销科室
        /// </summary>
        [XmlElement("write_off_section")]
        public string WriteOffSection { get; set; }

        /// <summary>
        /// 枚举值： 核销成功:SUCCESS 未使用:UNUSED 核销失败:FAIL
        /// </summary>
        [XmlElement("write_off_status")]
        public string WriteOffStatus { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [XmlElement("write_off_time")]
        public string WriteOffTime { get; set; }
    }
}
