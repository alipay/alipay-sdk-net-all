using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdTagCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasCrowdTagCreateModel : AopObject
    {
        /// <summary>
        /// 操作人ID+唯一
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人名称+不唯一
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 机构名称+不唯一
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 标签圈人人群基本信息+不唯一
        /// </summary>
        [XmlElement("tag_rule_crowd_dto")]
        public TagRuleCrowdDTO TagRuleCrowdDto { get; set; }

        /// <summary>
        /// 租户Code+唯一
        /// </summary>
        [XmlElement("tenant_code")]
        public string TenantCode { get; set; }
    }
}
