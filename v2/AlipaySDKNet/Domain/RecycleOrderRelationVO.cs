using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecycleOrderRelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class RecycleOrderRelationVO : AopObject
    {
        /// <summary>
        /// 关联描述
        /// </summary>
        [XmlElement("relation_desc")]
        public string RelationDesc { get; set; }

        /// <summary>
        /// 关联编号，如租赁订单号
        /// </summary>
        [XmlElement("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 关联关系类型
        /// </summary>
        [XmlElement("relation_type")]
        public string RelationType { get; set; }
    }
}
