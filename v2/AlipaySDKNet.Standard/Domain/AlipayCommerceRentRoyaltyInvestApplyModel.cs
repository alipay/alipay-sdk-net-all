using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRentRoyaltyInvestApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRentRoyaltyInvestApplyModel : AopObject
    {
        /// <summary>
        /// 操作类型，PAUSE：分账暂停；RECOVER：分账恢复
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 交易组件订单id列表
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("string")]
        public List<string> OrderList { get; set; }
    }
}
