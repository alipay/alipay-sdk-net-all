using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalRecord : AopObject
    {
        /// <summary>
        /// 就诊日期,格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("md_date")]
        public string MdDate { get; set; }

        /// <summary>
        /// 挂号流水号,同就诊id
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 结算类型
        /// </summary>
        [XmlElement("med_type")]
        public string MedType { get; set; }

        /// <summary>
        /// 院区id
        /// </summary>
        [XmlElement("medical_org_campus_id")]
        public string MedicalOrgCampusId { get; set; }

        /// <summary>
        /// 医疗机构ID
        /// </summary>
        [XmlElement("medical_org_id")]
        public string MedicalOrgId { get; set; }
    }
}
