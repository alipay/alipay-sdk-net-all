using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFDoctorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HDFDoctorInfo : AopObject
    {
        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 医生头像链接
        /// </summary>
        [XmlElement("head_image")]
        public string HeadImage { get; set; }

        /// <summary>
        /// 0  是女、1 男、2 未知
        /// </summary>
        [XmlElement("sex")]
        public long Sex { get; set; }
    }
}
