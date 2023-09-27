using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskQuery Data Structure.
    /// </summary>
    [Serializable]
    public class TaskQuery : AopObject
    {
        /// <summary>
        /// appKeys 应用列表
        /// </summary>
        [XmlArray("app_keys")]
        [XmlArrayItem("string")]
        public List<string> AppKeys { get; set; }

        /// <summary>
        /// 是否移动审批,默认为false
        /// </summary>
        [XmlElement("approve_enabled")]
        public bool ApproveEnabled { get; set; }

        /// <summary>
        /// 任务执行者工号，需要6位工号，不足6位需要补0
        /// </summary>
        [XmlElement("assignee_work_id")]
        public string AssigneeWorkId { get; set; }

        /// <summary>
        /// body,可以进行检索
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 流程发起者工号，需要6位工号，不足6位需要补0
        /// </summary>
        [XmlElement("creator_work_id")]
        public string CreatorWorkId { get; set; }

        /// <summary>
        /// 排序方式，默认：DESC
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("from_date")]
        public string FromDate { get; set; }

        /// <summary>
        /// 是否按包id分组
        /// </summary>
        [XmlElement("group_by_package")]
        public bool GroupByPackage { get; set; }

        /// <summary>
        /// 是否包含代理，默认为true
        /// </summary>
        [XmlElement("include_agent_task")]
        public bool IncludeAgentTask { get; set; }

        /// <summary>
        /// 业务索引1
        /// </summary>
        [XmlElement("index_1")]
        public string Index1 { get; set; }

        /// <summary>
        /// 业务索引2
        /// </summary>
        [XmlElement("index_2")]
        public string Index2 { get; set; }

        /// <summary>
        /// 业务索引3
        /// </summary>
        [XmlElement("index_3")]
        public string Index3 { get; set; }

        /// <summary>
        /// 业务索引4
        /// </summary>
        [XmlElement("index_4")]
        public string Index4 { get; set; }

        /// <summary>
        /// 是否催签
        /// </summary>
        [XmlElement("is_urge")]
        public bool IsUrge { get; set; }

        /// <summary>
        /// 语言(获取分组信息时可以根据语言得到对应的数据)
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 分页index
        /// </summary>
        [XmlElement("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页size，默认值为20
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 流程Code，按需使用
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 流程Code集合，不是所有业务方都需要
        /// </summary>
        [XmlArray("process_codes")]
        [XmlArrayItem("string")]
        public List<string> ProcessCodes { get; set; }

        /// <summary>
        /// 接入任务中心时，填写的source_id
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 系统二级分类名称
        /// </summary>
        [XmlElement("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// 系统二级分类名称英文
        /// </summary>
        [XmlElement("source_name_en")]
        public string SourceNameEn { get; set; }

        /// <summary>
        /// 系统二级分类名称英文
        /// </summary>
        [XmlArray("source_name_en_list")]
        [XmlArrayItem("string")]
        public List<string> SourceNameEnList { get; set; }

        /// <summary>
        /// 系统二级分类名称
        /// </summary>
        [XmlArray("source_name_list")]
        [XmlArrayItem("string")]
        public List<string> SourceNameList { get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 标题英文
        /// </summary>
        [XmlElement("subject_en")]
        public string SubjectEn { get; set; }

        /// <summary>
        /// 接入任务中心时，填写的system_type
        /// </summary>
        [XmlElement("system_type")]
        public string SystemType { get; set; }

        /// <summary>
        /// 分组ID
        /// </summary>
        [XmlElement("task_category_uuid")]
        public string TaskCategoryUuid { get; set; }

        /// <summary>
        /// 组合id
        /// </summary>
        [XmlArray("task_source_query_infos")]
        [XmlArrayItem("component_id")]
        public List<ComponentId> TaskSourceQueryInfos { get; set; }

        /// <summary>
        /// 任务状态，0新建 1取消 2已完成 3暂停 4忽视
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务状态集合
        /// </summary>
        [XmlArray("task_status_list")]
        [XmlArrayItem("number")]
        public List<long> TaskStatusList { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("to_date")]
        public string ToDate { get; set; }
    }
}
