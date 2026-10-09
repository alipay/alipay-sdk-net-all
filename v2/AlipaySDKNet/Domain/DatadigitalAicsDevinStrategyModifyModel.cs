using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinStrategyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinStrategyModifyModel : AopObject
    {
        /// <summary>
        /// String字符串传递Map。待更新字段键值数据，必填，支持部分更新；改可见性可仅传{"show_status":"..."}，具体字段由表单定义动态决定
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 表单编码，固定值 WORK（处理器校验必须为 WORK）
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 待编辑数据ID，必填，需大于0
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否脱敏，默认false
        /// </summary>
        [XmlElement("need_mask_field")]
        public bool NeedMaskField { get; set; }

        /// <summary>
        /// 租户ID，长度8-32位
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
