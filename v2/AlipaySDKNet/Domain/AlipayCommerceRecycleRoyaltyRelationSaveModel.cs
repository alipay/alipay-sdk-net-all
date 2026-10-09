using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleRoyaltyRelationSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleRoyaltyRelationSaveModel : AopObject
    {
        /// <summary>
        /// 关系绑定处理类型枚举
        /// </summary>
        [XmlElement("handle_type")]
        public string HandleType { get; set; }

        /// <summary>
        /// 分账关系操作列表，每次最多20个
        /// </summary>
        [XmlArray("relation_list")]
        [XmlArrayItem("recycle_royalty_relation_v_o")]
        public List<RecycleRoyaltyRelationVO> RelationList { get; set; }
    }
}
