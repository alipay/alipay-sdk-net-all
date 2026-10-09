using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalAicsDevinTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalAicsDevinTaskCreateModel : AopObject
    {
        /// <summary>
        /// 扩展信息(JSON字符串) 最大并发机器数=CC_MAX_LIMIT；振铃未接挂断时长（单位：秒）= outCallRingingTimeLimit；发起调用时的超时时间= LAUNCH_CALL_TIMEOUT
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

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
        /// 任务初始运行状态：0-启用 1-暂停
        /// </summary>
        [XmlElement("task_status")]
        public long TaskStatus { get; set; }

        /// <summary>
        /// 坐席=TRANSFER_AGENT；技能组=TRANSFER_SKILL_GROUP
        /// </summary>
        [XmlElement("task_transfer_type")]
        public string TaskTransferType { get; set; }

        /// <summary>
        /// 任务类型自动外呼=AUTO_CALL；手动外呼=OUTBOUND_CALL；IVR外呼=IVR_CALL；默认传递=BOOT_CALL
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 转接编码（坐席/技能组/IVR code）
        /// </summary>
        [XmlElement("transfer_code")]
        public string TransferCode { get; set; }
    }
}
