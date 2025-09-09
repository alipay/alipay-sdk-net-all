using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoMallPurchaseCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoMallPurchaseCreateModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 地址id 当前字段已废弃(填写完整address_detail即可)
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 购买者
        /// </summary>
        [XmlElement("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// 外部orderId
        /// </summary>
        [XmlElement("outer_purchase_id")]
        public string OuterPurchaseId { get; set; }

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
    }
}
