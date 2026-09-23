using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinStrategyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinStrategyCreateModel : AopObject
    {
        /// <summary>
        /// 策略字段键值数据，必填。key 见 WorkFiledEnum；下方 properties 为枚举字段及其全部取值，其余动态字段(name/priority/status/assigner/related_task_code/start_time/end_time/cue_count/complete_count/related_picked_id/cue_list/related_user 等)由表单定义、以 additionalProperties 任意键值透传。（JSON字符串格式，例如 {"name":"策略A","status":"1"}）
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 表单编码，固定值 WORK
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 是否脱敏，默认false
        /// </summary>
        [XmlElement("need_mask_field")]
        public bool NeedMaskField { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
