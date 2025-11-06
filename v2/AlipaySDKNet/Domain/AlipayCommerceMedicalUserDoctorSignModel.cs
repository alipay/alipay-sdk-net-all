using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalUserDoctorSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalUserDoctorSignModel : AopObject
    {
        /// <summary>
        /// 医生Id（机构签约为对应负责人）
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 签约对象类型下的唯一ID
        /// </summary>
        [XmlElement("sign_biz_id")]
        public string SignBizId { get; set; }

        /// <summary>
        /// 签约对象类型
        /// </summary>
        [XmlElement("sign_biz_type")]
        public string SignBizType { get; set; }

        /// <summary>
        /// 签约来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 签约内容
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
