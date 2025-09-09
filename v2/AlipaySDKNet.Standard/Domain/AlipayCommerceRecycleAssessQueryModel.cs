using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleAssessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleAssessQueryModel : AopObject
    {
        /// <summary>
        /// 用户回收地址信息
        /// </summary>
        [XmlElement("address_info")]
        public RecycleAddressInfo AddressInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 产品code
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 回收方式
        /// </summary>
        [XmlElement("recycle_approach")]
        public string RecycleApproach { get; set; }

        /// <summary>
        /// 问卷选项关系id集合
        /// </summary>
        [XmlArray("relation_id_list")]
        [XmlArrayItem("string")]
        public List<string> RelationIdList { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
