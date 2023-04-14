using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BusinessRelationChangeShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessRelationChangeShopInfo : AopObject
    {
        /// <summary>
        /// 异动收单信息列表
        /// </summary>
        [XmlArray("change_member_infos")]
        [XmlArrayItem("business_relation_change_member_info")]
        public List<BusinessRelationChangeMemberInfo> ChangeMemberInfos { get; set; }

        /// <summary>
        /// 异动数据新增时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 异动数据更新时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商业关系异动门店状态，已处理/未处理，PROCESSED/UNPROCESSED
        /// </summary>
        [XmlElement("process_status")]
        public string ProcessStatus { get; set; }

        /// <summary>
        /// 基于商业关系的代运营门店id
        /// </summary>
        [XmlElement("real_shop_id")]
        public string RealShopId { get; set; }

        /// <summary>
        /// 外部门店编号，用于ISV系统内部门店标识等
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 代运营商业关系门店名称，即当前组织下可运营门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }
    }
}
