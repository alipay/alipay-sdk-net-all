using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradePayinfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradePayinfoSyncModel : AopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public ExtInfoMap ExtInfos { get; set; }

        /// <summary>
        /// 是否使用商家营销 0-未使用商家优惠 1-已使用商家优惠
        /// </summary>
        [XmlElement("merchant_promo_status")]
        public string MerchantPromoStatus { get; set; }

        /// <summary>
        /// 总价，单位：元
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 子购物单信息
        /// </summary>
        [XmlArray("sub_goods_order_list")]
        [XmlArrayItem("goods_detail")]
        public List<GoodsDetail> SubGoodsOrderList { get; set; }
    }
}
