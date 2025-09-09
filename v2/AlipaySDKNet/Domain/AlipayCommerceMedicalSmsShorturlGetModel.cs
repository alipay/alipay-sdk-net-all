using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSmsShorturlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSmsShorturlGetModel : AopObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 可联系技术获取分配值
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 扁鹊
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 门诊报告
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }
    }
}
