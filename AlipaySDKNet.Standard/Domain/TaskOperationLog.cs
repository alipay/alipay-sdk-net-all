using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskOperationLog Data Structure.
    /// </summary>
    [Serializable]
    public class TaskOperationLog : AopObject
    {
        /// <summary>
        /// 操作时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [XmlElement("gmt_opration")]
        public string GmtOpration { get; set; }

        /// <summary>
        /// 操作详情描述
        /// </summary>
        [XmlElement("operation_desc")]
        public string OperationDesc { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [XmlElement("operation_memo")]
        public string OperationMemo { get; set; }

        /// <summary>
        /// 操作类型: CREATE：任务创建, MANUAL:手工添加动态, TRANSFER：任务转派, URGE：任务催办, RESPONSE：任务响应, DEAL：任务处理, EXP_RESUME：异常恢复
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [XmlElement("operator_nick")]
        public string OperatorNick { get; set; }
    }
}
