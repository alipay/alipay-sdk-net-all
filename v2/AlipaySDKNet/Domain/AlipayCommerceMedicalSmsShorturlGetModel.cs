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
        /// 如果身份类型是IDENTITY_CARD，这个必填
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

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
        /// 传入的手机号，如果有以这个手机号为主，如果用户没有绑定这个手机号还是取登陆时间最近的手机号
        /// </summary>
        [XmlElement("input_phone")]
        public string InputPhone { get; set; }

        /// <summary>
        /// 真实姓名，如果身份类型是IDENTITY_CARD，这个必填
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

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
        /// 渠道
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 门诊报告
        /// </summary>
        [XmlElement("sub_scene")]
        public string SubScene { get; set; }
    }
}
