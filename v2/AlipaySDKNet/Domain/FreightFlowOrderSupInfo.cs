using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowOrderSupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowOrderSupInfo : AopObject
    {
        /// <summary>
        /// 收货人电话
        /// </summary>
        [XmlElement("buyer_cell_phone")]
        public string BuyerCellPhone { get; set; }

        /// <summary>
        /// 收货人城市
        /// </summary>
        [XmlElement("buyer_city")]
        public string BuyerCity { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 收货人省份
        /// </summary>
        [XmlElement("buyer_province")]
        public string BuyerProvince { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("deliver_time")]
        public string DeliverTime { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 收货时间
        /// </summary>
        [XmlElement("receive_time")]
        public string ReceiveTime { get; set; }

        /// <summary>
        /// 发货人绑定银行卡号
        /// </summary>
        [XmlElement("seller_card_no")]
        public string SellerCardNo { get; set; }

        /// <summary>
        /// 发货人电话
        /// </summary>
        [XmlElement("seller_cell_phone")]
        public string SellerCellPhone { get; set; }

        /// <summary>
        /// 发货人城市
        /// </summary>
        [XmlElement("seller_city")]
        public string SellerCity { get; set; }

        /// <summary>
        /// 发货人姓名
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 创单人唯一id
        /// </summary>
        [XmlElement("seller_out_id")]
        public string SellerOutId { get; set; }

        /// <summary>
        /// 发货人省份
        /// </summary>
        [XmlElement("seller_province")]
        public string SellerProvince { get; set; }
    }
}
