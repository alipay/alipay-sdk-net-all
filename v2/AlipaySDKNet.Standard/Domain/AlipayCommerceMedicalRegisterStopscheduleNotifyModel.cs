using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterStopscheduleNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterStopscheduleNotifyModel : AopObject
    {
        /// <summary>
        /// yyyyMMdd.停诊日期.格式如上
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 服务商code.不可枚举
        /// </summary>
        [XmlElement("isv_code")]
        public string IsvCode { get; set; }

        /// <summary>
        /// 停诊取消
        /// </summary>
        [XmlElement("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// 平台 code
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 停诊原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 支持批量.registerIds 逗号分隔
        /// </summary>
        [XmlElement("register_ids")]
        public string RegisterIds { get; set; }

        /// <summary>
        /// 排班类型 上午
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
