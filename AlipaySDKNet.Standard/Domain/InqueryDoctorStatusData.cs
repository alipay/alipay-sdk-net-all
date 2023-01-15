using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InqueryDoctorStatusData Data Structure.
    /// </summary>
    [Serializable]
    public class InqueryDoctorStatusData : AopObject
    {
        /// <summary>
        /// 平均接诊时长（单位：分钟）
        /// </summary>
        [XmlElement("average_time")]
        public string AverageTime { get; set; }

        /// <summary>
        /// 医生平台状态
        /// </summary>
        [XmlElement("doctor_platform_status")]
        public string DoctorPlatformStatus { get; set; }

        /// <summary>
        /// 医生评价分数
        /// </summary>
        [XmlElement("evaluation_score")]
        public string EvaluationScore { get; set; }

        /// <summary>
        /// 医生身份证号（医生执医许可证编号和医生身份证号至少传一项）
        /// </summary>
        [XmlElement("id_no")]
        public string IdNo { get; set; }

        /// <summary>
        /// 问诊方式列表
        /// </summary>
        [XmlArray("inquiry_channel_list")]
        [XmlArrayItem("inquiry_channel")]
        public List<InquiryChannel> InquiryChannelList { get; set; }

        /// <summary>
        /// 外部平台医生id
        /// </summary>
        [XmlElement("merchant_doctor_id")]
        public string MerchantDoctorId { get; set; }

        /// <summary>
        /// 累计咨询人次
        /// </summary>
        [XmlElement("num_of_people_served")]
        public string NumOfPeopleServed { get; set; }

        /// <summary>
        /// 医生执医许可证编号（医生执医许可证编号和医生身份证号至少传一项）
        /// </summary>
        [XmlElement("practicing_doctor_certificate_no")]
        public string PracticingDoctorCertificateNo { get; set; }
    }
}
