using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoyagerOrderInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VoyagerOrderInfoDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("standard_goods_info")]
        public List<StandardGoodsInfo> GoodsList { get; set; }

        /// <summary>
        /// 二级商户MCC
        /// </summary>
        [XmlElement("merchant_mcc")]
        public string MerchantMcc { get; set; }

        /// <summary>
        /// 业务订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public MultiCurrencyMoneyDTO OrderAmount { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("order_description")]
        public string OrderDescription { get; set; }

        /// <summary>
        /// 业务订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 二级商户id
        /// </summary>
        [XmlElement("reference_merchant_id")]
        public string ReferenceMerchantId { get; set; }

        /// <summary>
        /// 结算策略
        /// </summary>
        [XmlElement("settlement_strategy")]
        public SettlementStrategyDTO SettlementStrategy { get; set; }
    }
}
