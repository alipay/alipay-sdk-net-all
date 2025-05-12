using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAppRes Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAppRes : AopObject
    {
        /// <summary>
        /// 创意动作类型
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 风控被限制原因 appId+principalId维度
        /// </summary>
        [XmlElement("app_principal_risk_memo")]
        public string AppPrincipalRiskMemo { get; set; }

        /// <summary>
        /// 被限制原因 appId维度
        /// </summary>
        [XmlElement("app_risk_memo")]
        public string AppRiskMemo { get; set; }

        /// <summary>
        /// 小程序状态.0:有效，1无效
        /// </summary>
        [XmlElement("app_status")]
        public long AppStatus { get; set; }

        /// <summary>
        /// 小程序说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 该小程序是否被限制。 0不限制 1限制
        /// </summary>
        [XmlElement("limitation_tag")]
        public long LimitationTag { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 是否被处置。0:正常，1:处置中
        /// </summary>
        [XmlElement("risk_type")]
        public long RiskType { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
