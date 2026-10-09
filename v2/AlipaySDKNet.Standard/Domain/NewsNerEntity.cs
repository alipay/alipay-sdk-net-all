using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NewsNerEntity Data Structure.
    /// </summary>
    [Serializable]
    public class NewsNerEntity : AopObject
    {
        /// <summary>
        /// 实体名称
        /// </summary>
        [XmlElement("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// 实体类型，cows公司，ppws个人，ogws机构
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 分类权重
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
