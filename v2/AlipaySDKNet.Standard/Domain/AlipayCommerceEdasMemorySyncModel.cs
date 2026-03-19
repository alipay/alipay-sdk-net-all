using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEdasMemorySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEdasMemorySyncModel : AopObject
    {
        /// <summary>
        /// 数据场景code，该字段为数据场景编码（Code），对应数据平台的场景标识。
        /// </summary>
        [XmlElement("data_scene_code")]
        public string DataSceneCode { get; set; }

        /// <summary>
        /// 行业项目ID，该字段为源自数据服务平台商户绑定关系的智能体应用ID，通常映射为智能体应用ID。 
        /// </summary>
        [XmlElement("industry_id")]
        public string IndustryId { get; set; }

        /// <summary>
        /// 租户id，该字段为关联数据服务平台鉴权体系的租户唯一标识。 
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 用户标识id，该字段为智能体应用用户的唯一身份标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户智能体query，该字段为用户向智能体发起的具体查询指令或自然语言。 
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 任务ID，通常映射为对话ID，用于标识当前查询的归属上下文并支持幂等性校验。 
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 用户标识id，该字段为智能体应用用户的唯一身份标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
