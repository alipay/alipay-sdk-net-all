using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderDetailDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderDetailDTO : AopObject
    {
        /// <summary>
        /// 商品详细信息
        /// </summary>
        [XmlArray("item_infos")]
        [XmlArrayItem("mini_goods_detail_info_d_t_o")]
        public List<MiniGoodsDetailInfoDTO> ItemInfos { get; set; }

        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlElement("pay_info")]
        public PayInfoDTO PayInfo { get; set; }

        /// <summary>
        /// 价格详细信息
        /// </summary>
        [XmlElement("price_info")]
        public PriceInfoDTO PriceInfo { get; set; }
    }
}
