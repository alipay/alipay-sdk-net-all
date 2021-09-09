using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneMobileCodeQueryResponse.
    /// </summary>
    public class AlipayInsSceneMobileCodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 投保人
        /// </summary>
        [XmlElement("applicant")]
        public InsurancePerson Applicant { get; set; }

        /// <summary>
        /// 保障期限
        /// </summary>
        [XmlElement("insurance_period")]
        public InsurancePeriod InsurancePeriod { get; set; }

        /// <summary>
        /// 被保人
        /// </summary>
        [XmlElement("insured")]
        public InsurancePerson Insured { get; set; }

        /// <summary>
        /// 设备信息
        /// </summary>
        [XmlElement("mobile_device_info")]
        public MobileDeviceInfo MobileDeviceInfo { get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 维修类型 unOfficial:严选；official:官修
        /// </summary>
        [XmlElement("repair_type")]
        public string RepairType { get; set; }

        /// <summary>
        /// 保障卡激活状态  inactivated:未激活，activated:已激活
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
