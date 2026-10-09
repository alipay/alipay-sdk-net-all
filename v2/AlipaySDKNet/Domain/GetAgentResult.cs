using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GetAgentResult Data Structure.
    /// </summary>
    [Serializable]
    public class GetAgentResult : AopObject
    {
        /// <summary>
        /// 智能体信息
        /// </summary>
        [XmlElement("doctor")]
        public Doctor Doctor { get; set; }

        /// <summary>
        /// 0.缺少信息 1.与灵知数据库重名 2.医院未开通服务 3.科室未标准化 4.医生未开通智能体 5.匹配成功（已开通医生智能体） 6.匹配多个
        /// </summary>
        [XmlElement("operation_status")]
        public string OperationStatus { get; set; }

        /// <summary>
        /// 0.缺少信息 1.与灵知数据库重名 2.医院未开通服务 3.科室未标准化 4.医生未开通智能体 5.匹配成功 6.匹配多个
        /// </summary>
        [XmlElement("operation_status_description")]
        public string OperationStatusDescription { get; set; }
    }
}
