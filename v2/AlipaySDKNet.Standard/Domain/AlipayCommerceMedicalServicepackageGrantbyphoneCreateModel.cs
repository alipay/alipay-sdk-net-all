using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalServicepackageGrantbyphoneCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalServicepackageGrantbyphoneCreateModel : AopObject
    {
        /// <summary>
        /// 服务生效期限，单位天
        /// </summary>
        [XmlElement("effect_days")]
        public long EffectDays { get; set; }

        /// <summary>
        /// 用户真实手机号
        /// </summary>
        [XmlElement("phone_no")]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 项目真实ID，灵枢平台配置获取
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }
    }
}
