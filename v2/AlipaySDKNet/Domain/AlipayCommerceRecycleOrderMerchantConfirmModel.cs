using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleOrderMerchantConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleOrderMerchantConfirmModel : AopObject
    {
        /// <summary>
        /// 二级回收商出资账号
        /// </summary>
        [XmlElement("deduct_out")]
        public RecycleDeductOutVO DeductOut { get; set; }

        /// <summary>
        /// 质检产品信息
        /// </summary>
        [XmlArray("inspect_products")]
        [XmlArrayItem("recycle_inspect_product_v_o")]
        public List<RecycleInspectProductVO> InspectProducts { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 单位=元, 两位精度
        /// </summary>
        [XmlElement("order_inspect_price")]
        public string OrderInspectPrice { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 分账信息。当前最多支持5个分账方。如有额外诉求联系BD
        /// </summary>
        [XmlArray("royalty_infos")]
        [XmlArrayItem("recycle_royalty_info")]
        public List<RecycleRoyaltyInfo> RoyaltyInfos { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
