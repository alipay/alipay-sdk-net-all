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
        /// 链接拼接参数，具体可以参考系分文档
        /// </summary>
        [XmlElement("param_info")]
        public string ParamInfo { get; set; }

        /// <summary>
        /// 可联系技术获取分配值
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 通用场景
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
