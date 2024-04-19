using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceUsertagCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceUsertagCreateModel : AopObject
    {
        /// <summary>
        /// 数据版本，格式为日期的yyyyMMdd
        /// </summary>
        [XmlElement("dt")]
        public string Dt { get; set; }

        /// <summary>
        /// 标签级别，表示标签绑定在那个层级
        /// </summary>
        [XmlElement("tag_level")]
        public string TagLevel { get; set; }

        /// <summary>
        /// 租户级别关联使用，如：租户级别为TENANT时，该值需要填写具体是哪个租户（CS_HELLOBIKE_MS）
        /// </summary>
        [XmlElement("tag_level_value")]
        public string TagLevelValue { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户标签的具体内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
