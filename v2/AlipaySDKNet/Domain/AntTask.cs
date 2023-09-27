using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntTask Data Structure.
    /// </summary>
    [Serializable]
    public class AntTask : AopObject
    {
        /// <summary>
        /// 节点ID
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 实际执行人
        /// </summary>
        [XmlElement("actual_work_id")]
        public string ActualWorkId { get; set; }

        /// <summary>
        /// 应用的key
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 是否允许移动审批
        /// </summary>
        [XmlElement("approve_enabled")]
        public bool ApproveEnabled { get; set; }

        /// <summary>
        /// 流程发起者工号，需要6位工号，不足6位需补0
        /// </summary>
        [XmlElement("assignee_work_id")]
        public string AssigneeWorkId { get; set; }

        /// <summary>
        /// body,可以进行检索
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 任务外部组合id
        /// </summary>
        [XmlElement("component_id")]
        public ComponentId ComponentId { get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 流程发起者工号，需要6位工号，不足6位需补0
        /// </summary>
        [XmlElement("creator_work_id")]
        public string CreatorWorkId { get; set; }

        /// <summary>
        /// 流程实例所属部门
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 任务希望完成时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务实际完成、取消等终止状态操作后的时间
        /// </summary>
        [XmlElement("finished_time")]
        public string FinishedTime { get; set; }

        /// <summary>
        /// 任务内部id，外部仅做展示即可
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

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
        /// 任务内部包id
        /// </summary>
        [XmlElement("internal_package_id")]
        public long InternalPackageId { get; set; }

        /// <summary>
        /// 最近的更新时间
        /// </summary>
        [XmlElement("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 代理任务对应的主任务id
        /// </summary>
        [XmlElement("main_task_id")]
        public string MainTaskId { get; set; }

        /// <summary>
        /// 移动端url
        /// </summary>
        [XmlElement("mobile_url")]
        public string MobileUrl { get; set; }

        /// <summary>
        /// 工号，不足6位，需要在前面补0
        /// </summary>
        [XmlElement("original_work_id")]
        public string OriginalWorkId { get; set; }

        /// <summary>
        /// 下次超时发送时间
        /// </summary>
        [XmlElement("overdue_send_next_time")]
        public string OverdueSendNextTime { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("overdue_time")]
        public string OverdueTime { get; set; }

        /// <summary>
        /// 任务所属人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [XmlElement("package_id")]
        public string PackageId { get; set; }

        /// <summary>
        /// 任务的父包id
        /// </summary>
        [XmlElement("parent_package_id")]
        public string ParentPackageId { get; set; }

        /// <summary>
        /// 流程Code，按需使用
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 代理任务Id集合，查询任务时使用
        /// </summary>
        [XmlArray("proxy_task_id_list")]
        [XmlArrayItem("string")]
        public List<string> ProxyTaskIdList { get; set; }

        /// <summary>
        /// 是否允许快捷审批 1是 0否
        /// </summary>
        [XmlElement("quick_approval")]
        public long QuickApproval { get; set; }

        /// <summary>
        /// 移动端地址
        /// </summary>
        [XmlElement("real_mobile_url")]
        public string RealMobileUrl { get; set; }

        /// <summary>
        /// 是否发送审批助手 1:发送  0:不发送
        /// </summary>
        [XmlElement("send_card")]
        public long SendCard { get; set; }

        /// <summary>
        /// 超时发送次数
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }

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
        /// 任务开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

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
        /// 任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态，0新建 1取消 2已完成 3暂停 4忽视
        /// </summary>
        [XmlElement("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 置顶时间
        /// </summary>
        [XmlElement("top_time")]
        public string TopTime { get; set; }

        /// <summary>
        /// 催签次数
        /// </summary>
        [XmlElement("urge_num")]
        public long UrgeNum { get; set; }

        /// <summary>
        /// PC端审批地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
