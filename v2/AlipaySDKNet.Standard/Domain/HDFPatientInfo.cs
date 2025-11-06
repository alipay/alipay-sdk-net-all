using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFPatientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HDFPatientInfo : AopObject
    {
        /// <summary>
        /// 生日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 患者id
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 0  女、 1 男、2 未知
        /// </summary>
        [XmlElement("sex")]
        public long Sex { get; set; }
    }
}
