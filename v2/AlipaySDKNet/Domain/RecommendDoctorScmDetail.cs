using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendDoctorScmDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendDoctorScmDetail : AopObject
    {
        /// <summary>
        /// 业务埋点
        /// </summary>
        [XmlElement("biz_scm")]
        public string BizScm { get; set; }

        /// <summary>
        /// 外部医生id
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生行业id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 欧拉埋点
        /// </summary>
        [XmlElement("med_ora_scm")]
        public string MedOraScm { get; set; }
    }
}
