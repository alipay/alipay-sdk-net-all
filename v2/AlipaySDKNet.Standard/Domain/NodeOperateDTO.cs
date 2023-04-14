using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NodeOperateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NodeOperateDTO : AopObject
    {
        /// <summary>
        /// 流程平台puid
        /// </summary>
        [XmlElement("ant_process_puid")]
        public string AntProcessPuid { get; set; }

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
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 节点显示名称
        /// </summary>
        [XmlElement("node_display_name")]
        public string NodeDisplayName { get; set; }

        /// <summary>
        /// 节点停留时长
        /// </summary>
        [XmlElement("node_duration")]
        public string NodeDuration { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("node_name")]
        public string NodeName { get; set; }

        /// <summary>
        /// 操作详情
        /// </summary>
        [XmlElement("operate_detail")]
        public string OperateDetail { get; set; }

        /// <summary>
        /// 操作时长
        /// </summary>
        [XmlElement("operate_duration")]
        public string OperateDuration { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 操作人域账号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator_work_no")]
        public string OperatorWorkNo { get; set; }

        /// <summary>
        /// 连通的状态
        /// </summary>
        [XmlElement("ticket_state")]
        public string TicketState { get; set; }

        /// <summary>
        /// 工单标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
