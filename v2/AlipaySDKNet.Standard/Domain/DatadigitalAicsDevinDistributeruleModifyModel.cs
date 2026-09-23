using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinDistributeruleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinDistributeruleModifyModel : AopObject
    {
        /// <summary>
        /// 待更新字段键值，必填，仅传需变更字段；具体字段由表单定义（JSON字符串格式，例如 {"name":"策略A","status":"1"}）
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 表单编码，固定值 DING_CUE_DISTRIBUTE_RULE
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 待编辑分派规则ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

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
