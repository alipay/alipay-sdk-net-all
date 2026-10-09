using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalRegisterStopclinicNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalRegisterStopclinicNotifyModel : AopObject
    {
        /// <summary>
        /// 停诊日期，格式: yyyy-MM-dd
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 医院id
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 停诊类型
        /// </summary>
        [XmlElement("nofity_type")]
        public string NofityType { get; set; }

        /// <summary>
        /// 平台编码，联系支付宝解决方案给出
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 停诊原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 医院排班id
        /// </summary>
        [XmlElement("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 停诊类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
