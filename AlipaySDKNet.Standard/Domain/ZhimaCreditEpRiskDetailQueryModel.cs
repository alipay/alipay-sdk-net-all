using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpRiskDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpRiskDetailQueryModel : AopObject
    {
        /// <summary>
        /// 企业注册号或统一社会信用代码
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业全称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 页码从1开始
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 风险场景策略id
        /// </summary>
        [XmlElement("risk_strategy_id")]
        public string RiskStrategyId { get; set; }

        /// <summary>
        /// 业务场景码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
