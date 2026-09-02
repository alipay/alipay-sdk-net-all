using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HospitalConfigItem Data Structure.
    /// </summary>
    [Serializable]
    public class HospitalConfigItem : AopObject
    {
        /// <summary>
        /// 参数值
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 灰度配置，取值为true/false，没有则不填
        /// </summary>
        [XmlElement("gray_config")]
        public bool GrayConfig { get; set; }

        /// <summary>
        /// 院区编码
        /// </summary>
        [XmlElement("hospital_id")]
        public string HospitalId { get; set; }

        /// <summary>
        /// 医院机构编码
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }
    }
}
