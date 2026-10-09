using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinDistributeruleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinDistributeruleCreateModel : AopObject
    {
        /// <summary>
        /// 分派规则字段键值，必填；含 rule_name/rule_status/execution_type/condition_type/distribute_type/distribute_detail 等，具体字段由表单定义（JSON字符串格式，例如 {"name":"策略A","status":"1"}）
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 表单编码，固定值 DING_CUE_DISTRIBUTE_RULE
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
