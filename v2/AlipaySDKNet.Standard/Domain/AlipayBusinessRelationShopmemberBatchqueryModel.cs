using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationShopmemberBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationShopmemberBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商业关系组织id 由组织信息创建接口返回或bd分配或业务标识id，如mallid
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
        /// 支付宝内部物理门店编号。real_shop_no和real_shop_id至少传一个。如果同时传以real_shop_id为准
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 外部门店编号，用于ISV系统内部门店标识等.real_shop_no和real_shop_id至少传一个。如果同时传以real_shop_id为准
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }
    }
}
