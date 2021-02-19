using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InterTradeApprovalWorkflowOperateLogVO Data Structure.
    /// </summary>
    [Serializable]
    public class InterTradeApprovalWorkflowOperateLogVO : AopObject
    {
        /// <summary>
        /// 节点业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [XmlElement("operate_memo")]
        public string OperateMemo { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operate_type_name")]
        public string OperateTypeName { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operator_time")]
        public string OperatorTime { get; set; }
    }
}
