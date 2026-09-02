using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalChildgrowthDataQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalChildgrowthDataQueryModel : AopObject
    {
        /// <summary>
        /// 组织ID（租户隔离）
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 数据类型，当前仅支持 CHILD_GROWTH
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 解读业务ID。传入时精确查询指定 AI 解读；为空时自动取最新成长记录的 recordBizId 作为解读业务ID
        /// </summary>
        [XmlElement("interp_biz_id")]
        public string InterpBizId { get; set; }

        /// <summary>
        /// 用户OPENID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 组织ID（租户隔离）
        /// </summary>
        [XmlElement("org_id")]
        public string OrgId { get; set; }

        /// <summary>
        /// 成员档案ID（指定要查询的儿童成员）
        /// </summary>
        [XmlElement("profile_id")]
        public string ProfileId { get; set; }

        /// <summary>
        /// 记录查询截止日期，格式 yyyy-MM-dd（实现侧自动补全到当日 23:59:59）
        /// </summary>
        [XmlElement("record_end_date")]
        public string RecordEndDate { get; set; }

        /// <summary>
        /// 记录查询起始日期，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("record_start_date")]
        public string RecordStartDate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
