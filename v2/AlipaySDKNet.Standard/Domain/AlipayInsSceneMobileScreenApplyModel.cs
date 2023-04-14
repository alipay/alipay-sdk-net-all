using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneMobileScreenApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneMobileScreenApplyModel : AopObject
    {
        /// <summary>
        /// 投保人信息
        /// </summary>
        [XmlElement("applicant")]
        public InsurancePerson Applicant { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道业务信息
        /// </summary>
        [XmlElement("channel_biz_data")]
        public ChannelBizData ChannelBizData { get; set; }

        /// <summary>
        /// 保险保障开始时间
        /// </summary>
        [XmlElement("effective_start_time")]
        public string EffectiveStartTime { get; set; }

        /// <summary>
        /// 保障期限对象
        /// </summary>
        [XmlElement("insurance_period")]
        public InsurancePeriod InsurancePeriod { get; set; }

        /// <summary>
        /// 被保人信息
        /// </summary>
        [XmlElement("insured")]
        public InsurancePerson Insured { get; set; }

        /// <summary>
        /// 手机设备信息
        /// </summary>
        [XmlElement("mobile_device_info")]
        public MobileDeviceInfo MobileDeviceInfo { get; set; }

        /// <summary>
        /// 外部业务单号，幂等字段
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保费金额，单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 维修类型 官修：official; 严选：unOfficial;
        /// </summary>
        [XmlElement("repair_type")]
        public string RepairType { get; set; }
    }
}
