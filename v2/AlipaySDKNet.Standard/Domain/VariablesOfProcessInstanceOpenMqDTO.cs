using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VariablesOfProcessInstanceOpenMqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VariablesOfProcessInstanceOpenMqDTO : AopObject
    {
        /// <summary>
        /// appKey
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 变量名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        [XmlElement("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 变量值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }

        /// <summary>
        /// 变量id
        /// </summary>
        [XmlElement("variable_id")]
        public string VariableId { get; set; }
    }
}
