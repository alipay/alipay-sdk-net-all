using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RebusinessEntityRelation Data Structure.
    /// </summary>
    [Serializable]
    public class RebusinessEntityRelation : AopObject
    {
        /// <summary>
        /// 企业关系列表
        /// </summary>
        [XmlArray("org_list")]
        [XmlArrayItem("company_relation_info")]
        public List<CompanyRelationInfo> OrgList { get; set; }

        /// <summary>
        /// 店铺关系列表
        /// </summary>
        [XmlArray("shop_list")]
        [XmlArrayItem("shop_relation_info")]
        public List<ShopRelationInfo> ShopList { get; set; }
    }
}
