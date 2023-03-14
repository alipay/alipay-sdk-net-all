using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdAsiadReceiptCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAsiadReceiptCreateModel : AopObject
    {
        /// <summary>
        /// 应用的中文
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// INFORM：同步给亚运工单平台 HANDLE：需要亚运工单平台协同处置，并告知处置结果
        /// </summary>
        [XmlElement("cooperate_mode")]
        public string CooperateMode { get; set; }

        /// <summary>
        /// 故障描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 结束时间，uct时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 故障action
        /// </summary>
        [XmlElement("fault_action")]
        public string FaultAction { get; set; }

        /// <summary>
        /// 故障影响面
        /// </summary>
        [XmlElement("fault_effect")]
        public string FaultEffect { get; set; }

        /// <summary>
        /// 故障影响面的值
        /// </summary>
        [XmlElement("fault_effect_value")]
        public string FaultEffectValue { get; set; }

        /// <summary>
        /// 故障处置人
        /// </summary>
        [XmlElement("fault_handler")]
        public string FaultHandler { get; set; }

        /// <summary>
        /// 可选枚举数值：X1 X2 X3 X4 Y1 Y2 Y3 Y4 Pre-X Pre-Y
        /// </summary>
        [XmlElement("fault_level")]
        public string FaultLevel { get; set; }

        /// <summary>
        /// 故障的责任方
        /// </summary>
        [XmlElement("fault_responsible")]
        public string FaultResponsible { get; set; }

        /// <summary>
        /// 监控告警、极光、客户反馈
        /// </summary>
        [XmlElement("fault_source")]
        public string FaultSource { get; set; }

        /// <summary>
        /// 故障状态
        /// </summary>
        [XmlElement("fault_status")]
        public string FaultStatus { get; set; }

        /// <summary>
        /// 基础设施
        /// </summary>
        [XmlElement("fault_type")]
        public string FaultType { get; set; }

        /// <summary>
        /// 应用分组
        /// </summary>
        [XmlElement("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 根据此不同的值执行不同流程
        /// </summary>
        [XmlElement("request_key")]
        public string RequestKey { get; set; }

        /// <summary>
        /// 故障开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 第十九届亚运会
        /// </summary>
        [XmlElement("tenant_name")]
        public string TenantName { get; set; }

        /// <summary>
        /// 示例：批量ES查询和插入失败
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
