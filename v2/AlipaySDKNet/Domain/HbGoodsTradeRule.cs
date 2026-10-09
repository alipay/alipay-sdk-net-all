using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbGoodsTradeRule Data Structure.
    /// </summary>
    [Serializable]
    public class HbGoodsTradeRule : AopObject
    {
        /// <summary>
        /// 最大购买次数
        /// </summary>
        [XmlElement("max_buy_frequency")]
        public long MaxBuyFrequency { get; set; }

        /// <summary>
        /// 最大购买数量
        /// </summary>
        [XmlElement("max_buy_quantity")]
        public long MaxBuyQuantity { get; set; }

        /// <summary>
        /// 最小购买数量
        /// </summary>
        [XmlElement("min_buy_quantity")]
        public long MinBuyQuantity { get; set; }

        /// <summary>
        /// 一次最大购买数量
        /// </summary>
        [XmlElement("one_max_quantity")]
        public long OneMaxQuantity { get; set; }

        /// <summary>
        /// 服务费占比
        /// </summary>
        [XmlElement("service_fee_ratio")]
        public string ServiceFeeRatio { get; set; }
    }
}
