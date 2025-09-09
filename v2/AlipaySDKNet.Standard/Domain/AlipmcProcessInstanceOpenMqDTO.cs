using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipmcProcessInstanceOpenMqDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AlipmcProcessInstanceOpenMqDTO : AopObject
    {
        /// <summary>
        /// appKey
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 业务系统ID
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 标记是否删除
        /// </summary>
        [XmlElement("deleted_flag")]
        public bool DeletedFlag { get; set; }

        /// <summary>
        /// 是否依赖动态流程定义
        /// </summary>
        [XmlElement("dynamic_process_flag")]
        public bool DynamicProcessFlag { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        [XmlElement("finish_time")]
        public string FinishTime { get; set; }

        /// <summary>
        /// 流程实例主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 发起者id
        /// </summary>
        [XmlElement("originator_id")]
        public string OriginatorId { get; set; }

        /// <summary>
        /// 发起人JOB
        /// </summary>
        [XmlElement("originator_job")]
        public string OriginatorJob { get; set; }

        /// <summary>
        /// 实例完成结果
        /// </summary>
        [XmlElement("out_result")]
        public string OutResult { get; set; }

        /// <summary>
        /// 直系父流程实例id
        /// </summary>
        [XmlElement("parent_process_instance_id")]
        public string ParentProcessInstanceId { get; set; }

        /// <summary>
        /// 流程定义代号
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 流程定义id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 流程实例id
        /// </summary>
        [XmlElement("process_instance_id")]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 流程状态
        /// </summary>
        [XmlElement("process_instance_status")]
        public string ProcessInstanceStatus { get; set; }

        /// <summary>
        /// 流程版本
        /// </summary>
        [XmlElement("process_version")]
        public string ProcessVersion { get; set; }

        /// <summary>
        /// 根父流程实例id
        /// </summary>
        [XmlElement("root_parent_process_instance_id")]
        public string RootParentProcessInstanceId { get; set; }

        /// <summary>
        /// 子流程实例id
        /// </summary>
        [XmlElement("super_process_instance_id")]
        public string SuperProcessInstanceId { get; set; }

        /// <summary>
        /// 流程标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 流程英文标题
        /// </summary>
        [XmlElement("title_en")]
        public string TitleEn { get; set; }

        /// <summary>
        /// 是否已执行url转卡片
        /// </summary>
        [XmlElement("url_card_flag")]
        public bool UrlCardFlag { get; set; }
    }
}
