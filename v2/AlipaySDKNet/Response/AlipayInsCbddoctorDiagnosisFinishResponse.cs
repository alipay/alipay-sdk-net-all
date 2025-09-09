using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsCbddoctorDiagnosisFinishResponse.
    /// </summary>
    public class AlipayInsCbddoctorDiagnosisFinishResponse : AopResponse
    {
        /// <summary>
        /// 医生在蚂蚁插件填写的病情处置建议
        /// </summary>
        [XmlElement("disposal_advice")]
        public string DisposalAdvice { get; set; }

        /// <summary>
        /// 蚂蚁插件医生填写的是否有效问诊标识[true,false]
        /// </summary>
        [XmlElement("doctor_beneficial")]
        public bool DoctorBeneficial { get; set; }

        /// <summary>
        /// 医生在蚂蚁插件填写的就诊人病情描述
        /// </summary>
        [XmlElement("illness_desc")]
        public string IllnessDesc { get; set; }

        /// <summary>
        /// 医生在蚂蚁插件填写的就诊人年龄字符串（数字+年龄单位），单位分别为["Y","M","D"]，示例如下： 28Y代表28岁 6M代表6个月 25D代表25天
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 医生蚂蚁插件填写的就诊人性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }
    }
}
