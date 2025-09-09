using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlusRegisterInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlusRegisterInfo : AopObject
    {
        /// <summary>
        /// 地址描述
        /// </summary>
        [XmlElement("write_off_address")]
        public string WriteOffAddress { get; set; }

        /// <summary>
        /// 用于生成核销二维码
        /// </summary>
        [XmlElement("write_off_code")]
        public string WriteOffCode { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("write_off_doctor")]
        public string WriteOffDoctor { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("write_off_section")]
        public string WriteOffSection { get; set; }

        /// <summary>
        /// 核销状态，传值参照枚举定义
        /// </summary>
        [XmlElement("write_off_status")]
        public string WriteOffStatus { get; set; }

        /// <summary>
        /// 时间格式参照示例
        /// </summary>
        [XmlElement("write_off_time")]
        public string WriteOffTime { get; set; }
    }
}
