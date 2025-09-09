using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallPurchaseConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallPurchaseConsultModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 地址id 当前字段已废弃(迭代后无需此字段，已合并进address_detail)
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 购买者
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 四级地址code（区/县级）
        /// </summary>
        [XmlElement("division_code")]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("product_list")]
        [XmlArrayItem("product_v_o")]
        public List<ProductVO> ProductList { get; set; }

        /// <summary>
        /// 收货人
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 五级地址code（乡镇/街道级)
        /// </summary>
        [XmlElement("town_division_code")]
        public string TownDivisionCode { get; set; }
    }
}
