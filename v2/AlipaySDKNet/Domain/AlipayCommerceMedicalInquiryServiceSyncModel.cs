using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalInquiryServiceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalInquiryServiceSyncModel : AopObject
    {
        /// <summary>
        /// 平均接诊时间，单位：分钟
        /// </summary>
        [XmlElement("average_time")]
        public string AverageTime { get; set; }

        /// <summary>
        /// 数据版本号（更新时+1）
        /// </summary>
        [XmlElement("data_version")]
        public string DataVersion { get; set; }

        /// <summary>
        /// 三方医生编码
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生评价分数
        /// </summary>
        [XmlElement("evaluation_score")]
        public string EvaluationScore { get; set; }

        /// <summary>
        /// 问诊方式
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 问诊价格，单位：元
        /// </summary>
        [XmlElement("inquiry_price")]
        public string InquiryPrice { get; set; }

        /// <summary>
        /// 问诊类型
        /// </summary>
        [XmlElement("inquiry_type")]
        public string InquiryType { get; set; }

        /// <summary>
        /// 问诊服务链接
        /// </summary>
        [XmlElement("inquiry_url")]
        public string InquiryUrl { get; set; }

        /// <summary>
        /// 服务商编码
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 累计咨询人次
        /// </summary>
        [XmlElement("num_of_people_served")]
        public string NumOfPeopleServed { get; set; }

        /// <summary>
        /// 来源平台 code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 服务时长，单位：分钟
        /// </summary>
        [XmlElement("service_duration")]
        public string ServiceDuration { get; set; }

        /// <summary>
        /// 三方服务编码
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 问诊服务状态(ONLINE/OFFLINE)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
