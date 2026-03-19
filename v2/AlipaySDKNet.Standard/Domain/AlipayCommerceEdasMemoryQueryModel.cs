using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEdasMemoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEdasMemoryQueryModel : AopObject
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
        /// 用户标识id，该字段为智能体应用用户的唯一身份标识
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
