using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationShopdetailQueryModel : AopObject
    {
        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }
    }
}
