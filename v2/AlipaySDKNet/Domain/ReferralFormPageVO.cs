using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReferralFormPageVO Data Structure.
    /// </summary>
    [Serializable]
    public class ReferralFormPageVO : AopObject
    {
        /// <summary>
        /// 转诊人的年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 转诊申请人所在的区县
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 转诊签约医生的身份证号
        /// </summary>
        [XmlElement("doctor_cert_no")]
        public string DoctorCertNo { get; set; }

        /// <summary>
        /// 转诊申请的时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 转诊申请人的姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 转诊单单号，为转诊单表的主键，自动生成
        /// </summary>
        [XmlElement("referral_form_id")]
        public string ReferralFormId { get; set; }

        /// <summary>
        /// 转诊申请人的性别
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 转诊单的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转诊申请人的病情描述
        /// </summary>
        [XmlElement("user_description")]
        public string UserDescription { get; set; }
    }
}
