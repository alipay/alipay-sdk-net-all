using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShoppoolShopGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShoppoolShopGetModel : AopObject
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业码门店组id，和shop_id_list二选一
        /// </summary>
        [XmlElement("shop_group_id")]
        public string ShopGroupId { get; set; }

        /// <summary>
        /// 企业码门店id列表，最大支持50个，和shop_group_id二选一
        /// </summary>
        [XmlArray("shop_id_list")]
        [XmlArrayItem("string")]
        public List<string> ShopIdList { get; set; }
    }
}
