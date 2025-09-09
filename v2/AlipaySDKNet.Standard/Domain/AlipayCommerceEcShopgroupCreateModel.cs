using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcShopgroupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcShopgroupCreateModel : AopObject
    {
        /// <summary>
        /// 地址信息，表示查询符合此地址规则的门店
        /// </summary>
        [XmlElement("address_info")]
        public AdressInfo AddressInfo { get; set; }

        /// <summary>
        /// 门店搜索条件列表，支持多个条件，并按照优先级进行搜索匹配
        /// </summary>
        [XmlArray("condition_list")]
        [XmlArrayItem("condition_info")]
        public List<ConditionInfo> ConditionList { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 电子围栏信息，表示查询在此范围内的门店
        /// </summary>
        [XmlElement("fence_info")]
        public FenceInfo FenceInfo { get; set; }

        /// <summary>
        /// 门店组名称
        /// </summary>
        [XmlElement("shop_group_name")]
        public string ShopGroupName { get; set; }

        /// <summary>
        /// 门店类型，可选值：餐饮门店 - MEAL；理赔医院 - HOSPITAL
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
