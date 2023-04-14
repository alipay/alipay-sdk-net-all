using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChannelBizData Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelBizData : AopObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [XmlElement("goods_info")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 订单信息详情
        /// </summary>
        [XmlElement("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 价格因子
        /// </summary>
        [XmlElement("premium_factor")]
        public string PremiumFactor { get; set; }
    }
}
