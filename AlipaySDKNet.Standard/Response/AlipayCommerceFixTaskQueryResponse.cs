using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceFixTaskQueryResponse.
    /// </summary>
    public class AlipayCommerceFixTaskQueryResponse : AopResponse
    {
        /// <summary>
        /// 部分规则场景下，对提报问题进行的二次分类
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 任务完结时间。用户确认后的时间。如果业务场景中不需要用户确认，则这里和start_confirm_time的值一样。
        /// </summary>
        [XmlElement("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 问题的处理详情，json格式的数据。数据详情请与业务接口人沟通，。
        /// </summary>
        [XmlElement("conclusion_ext_info")]
        public string ConclusionExtInfo { get; set; }

        /// <summary>
        /// 处理结论的说明
        /// </summary>
        [XmlElement("conclusion_memo")]
        public string ConclusionMemo { get; set; }

        /// <summary>
        /// 处理结论-问题类型
        /// </summary>
        [XmlElement("conclusion_type")]
        public string ConclusionType { get; set; }

        /// <summary>
        /// 工单关联的协作任务。一个工单可能涉及多方处理，这个列表包含全部的处理历史信息
        /// </summary>
        [XmlArray("cooperations")]
        [XmlArrayItem("fix_cooperation_d_t_o")]
        public List<FixCooperationDTO> Cooperations { get; set; }

        /// <summary>
        /// 当前处理中的协作任务id
        /// </summary>
        [XmlElement("current_cooperation_id")]
        public long CurrentCooperationId { get; set; }

        /// <summary>
        /// 当前处理人的名字，脱敏显示
        /// </summary>
        [XmlElement("duty_owner_name")]
        public string DutyOwnerName { get; set; }

        /// <summary>
        /// 当前处理人的联系方式，脱敏显示
        /// </summary>
        [XmlElement("duty_owner_phone")]
        public string DutyOwnerPhone { get; set; }

        /// <summary>
        /// 定向开放场景中，可能同时支持多个业务场景，允许各业务场景自定义个性化提交的数据。数据格式请提前与业务接口人确定
        /// </summary>
        [XmlElement("extra_info")]
        public FixExtData ExtraInfo { get; set; }

        /// <summary>
        /// 工单中包含的文件信息，可以通过download_url下载到文件内容
        /// </summary>
        [XmlArray("files")]
        [XmlArrayItem("fix_file_info")]
        public List<FixFileInfo> Files { get; set; }

        /// <summary>
        /// 任务首次受理时间。代表任务开始处理
        /// </summary>
        [XmlElement("first_apply_time")]
        public string FirstApplyTime { get; set; }

        /// <summary>
        /// 工单的创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用户的问题是否解决。yes:已解决;no:未解决
        /// </summary>
        [XmlElement("is_resolved")]
        public string IsResolved { get; set; }

        /// <summary>
        /// 首次提报时的问题分类信息。
        /// </summary>
        [XmlElement("original_problem")]
        public FixProblemDTO OriginalProblem { get; set; }

        /// <summary>
        /// 当前处理方的公司名，脱敏显示
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 当前的问题分类描述信息。问题可能多次流转，这里是当前最新的问题分类描述信息
        /// </summary>
        [XmlElement("problem")]
        public FixProblemDTO Problem { get; set; }

        /// <summary>
        /// 工单的规则场景
        /// </summary>
        [XmlElement("rule_scene")]
        public string RuleScene { get; set; }

        /// <summary>
        /// 任务开始确认时间。代表处理方已经完成任务处理，等待提交问题的用户确认
        /// </summary>
        [XmlElement("start_confirm_time")]
        public string StartConfirmTime { get; set; }

        /// <summary>
        /// 工单当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 当前状态的中文名
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }

        /// <summary>
        /// 用来标识任务类型。 枚举值:techConsult:技术咨询;malfunctionReport:设备报障
        /// </summary>
        [XmlElement("task_category")]
        public string TaskCategory { get; set; }

        /// <summary>
        /// 工单的任务类型
        /// </summary>
        [XmlElement("task_type")]
        public string TaskType { get; set; }

        /// <summary>
        /// 问题未能解决的原因说明
        /// </summary>
        [XmlElement("unresolved_reason")]
        public string UnresolvedReason { get; set; }
    }
}
