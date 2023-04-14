using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderDetailInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class OrderDetailInfoVO : AopObject
    {
        /// <summary>
        /// 商品列表
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("order_item_info_v_o")]
        public List<OrderItemInfoVO> ItemInfos { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("pay_info")]
        public PayInfoVO PayInfo { get; set; }

        /// <summary>
        /// 价格信息
        /// </summary>
        [XmlElement("price_info")]
        public PriceInfoVO PriceInfo { get; set; }
    }
}
