using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BPOpenApiTicketOperateTrace Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiTicketOperateTrace : AopObject
    {
        /// <summary>
        /// 所做的操作
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 业务系统
        /// </summary>
        [XmlElement("biz_app")]
        public string BizApp { get; set; }

        /// <summary>
        /// 业务id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 处理节点显示名称
        /// </summary>
        [XmlElement("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 处理节点名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 下一步处理节点显示名称
        /// </summary>
        [XmlElement("next_display_name")]
        public string NextDisplayName { get; set; }

        /// <summary>
        /// 下一步处理节点
        /// </summary>
        [XmlElement("next_name")]
        public string NextName { get; set; }

        /// <summary>
        /// 节点停留时长
        /// </summary>
        [XmlElement("node_duration")]
        public long NodeDuration { get; set; }

        /// <summary>
        /// 操作名称
        /// </summary>
        [XmlElement("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 节点处理时长
        /// </summary>
        [XmlElement("operate_duration")]
        public long OperateDuration { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作者用户域名
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作者花名
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 原处理人域名
        /// </summary>
        [XmlElement("origin_operator")]
        public string OriginOperator { get; set; }

        /// <summary>
        /// 原处理人花名
        /// </summary>
        [XmlElement("origin_operator_name")]
        public string OriginOperatorName { get; set; }

        /// <summary>
        /// 工单id
        /// </summary>
        [XmlElement("ticket_id")]
        public string TicketId { get; set; }
    }
}
