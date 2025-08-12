using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsInfoModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsInfoModifyDTO : AopObject
    {
        /// <summary>
        /// 商品属性信息
        /// </summary>
        [XmlArray("attr_ext_info_list")]
        [XmlArrayItem("attr_ext_info_d_t_o")]
        public List<AttrExtInfoDTO> AttrExtInfoList { get; set; }

        /// <summary>
        /// 质检金额，单位为元
        /// </summary>
        [XmlElement("inspect_price")]
        public string InspectPrice { get; set; }

        /// <summary>
        /// 提报商品库的商品
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }

        /// <summary>
        /// 提报商品库的商品
        /// </summary>
        [XmlElement("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品回收状态
        /// </summary>
        [XmlElement("recycle_status")]
        public string RecycleStatus { get; set; }

        /// <summary>
        /// 商品租赁信息
        /// </summary>
        [XmlElement("rent_info")]
        public RentInfoDTO RentInfo { get; set; }
    }
}
