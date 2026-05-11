using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphonenoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageGrantbyphonenoCreateModel : AopObject
    {
        /// <summary>
        /// 服务生效天数
        /// </summary>
        [XmlElement("effect_days")]
        public long EffectDays { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
