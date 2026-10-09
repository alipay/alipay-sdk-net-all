using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinTaskModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinTaskModifyModel : AopObject
    {
        /// <summary>
        /// 获取状态
        /// </summary>
        [XmlElement("acquire_status")]
        public string AcquireStatus { get; set; }

        /// <summary>
        /// 扩展信息(JSON字符串)
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 上次获取状态
        /// </summary>
        [XmlElement("last_acquire_status")]
        public string LastAcquireStatus { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [XmlElement("outbound_caller")]
        public string OutboundCaller { get; set; }

        /// <summary>
        /// 任务code
        /// </summary>
        [XmlElement("task_code")]
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [XmlElement("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务规则code
        /// </summary>
        [XmlElement("task_rules_code")]
        public string TaskRulesCode { get; set; }

        /// <summary>
        /// 任务操作：1-暂停 2-继续 4-终止
        /// </summary>
        [XmlElement("task_status")]
        public long TaskStatus { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 转接编码
        /// </summary>
        [XmlElement("transfer_code")]
        public string TransferCode { get; set; }

        /// <summary>
        /// 版本号(乐观锁)
        /// </summary>
        [XmlElement("version_on")]
        public string VersionOn { get; set; }
    }
}
