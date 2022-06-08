using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdLogicalCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasCrowdLogicalCreateModel : AopObject
    {
        /// <summary>
        /// 逻辑圈人人群基本信息+不唯一
        /// </summary>
        [XmlElement("logical_rule_crowd_dto")]
        public LogicalRuleCrowdDTO LogicalRuleCrowdDto { get; set; }

        /// <summary>
        /// 操作人ID+唯一
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人姓名+不唯一
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 机构名称+不唯一
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 租户Code+唯一
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
