using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorTempLimitInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorTempLimitInfoDTO : AopObject
    {
        /// <summary>
        /// 临额可用额度，单位：分
        /// </summary>
        [XmlElement("temp_available_limit")]
        public string TempAvailableLimit { get; set; }

        /// <summary>
        /// 临额授信额度，单位：分
        /// </summary>
        [XmlElement("temp_credit_limit")]
        public string TempCreditLimit { get; set; }

        /// <summary>
        /// 临额有效期(截止时间), 示例:   2023-09-23 23:59:59
        /// </summary>
        [XmlElement("temp_limit_valid_time")]
        public string TempLimitValidTime { get; set; }
    }
}
