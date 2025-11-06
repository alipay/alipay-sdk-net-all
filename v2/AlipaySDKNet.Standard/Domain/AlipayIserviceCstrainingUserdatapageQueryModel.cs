using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCstrainingUserdatapageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCstrainingUserdatapageQueryModel : AopObject
    {
        /// <summary>
        /// 匹配id
        /// </summary>
        [XmlElement("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 训练结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 组织架构id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 是否通过
        /// </summary>
        [XmlElement("is_passed")]
        public string IsPassed { get; set; }

        /// <summary>
        /// 学员的标识id
        /// </summary>
        [XmlElement("member_id")]
        public string MemberId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页数量的条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 学习路径的id
        /// </summary>
        [XmlElement("path_id")]
        public string PathId { get; set; }

        /// <summary>
        /// 学习路径名称
        /// </summary>
        [XmlElement("path_name")]
        public string PathName { get; set; }

        /// <summary>
        /// 路径状态
        /// </summary>
        [XmlElement("path_status")]
        public string PathStatus { get; set; }

        /// <summary>
        /// 台本id
        /// </summary>
        [XmlElement("playscript_id")]
        public string PlayscriptId { get; set; }

        /// <summary>
        /// 台本名称
        /// </summary>
        [XmlElement("playscript_name")]
        public string PlayscriptName { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [XmlElement("resource_name")]
        public string ResourceName { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// 阶段名称
        /// </summary>
        [XmlElement("stage_name")]
        public string StageName { get; set; }

        /// <summary>
        /// 训练开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 训练类型
        /// </summary>
        [XmlElement("training_type")]
        public string TrainingType { get; set; }

        /// <summary>
        /// 学员名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
