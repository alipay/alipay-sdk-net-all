using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantActivityGoodsStockIncrease Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantActivityGoodsStockIncrease : AopObject
    {
        /// <summary>
        /// 活动权益增补库存信息
        /// </summary>
        [XmlArray("goods_benefit_increase_stock")]
        [XmlArrayItem("activity_goods_stock_increase")]
        public List<ActivityGoodsStockIncrease> GoodsBenefitIncreaseStock { get; set; }

        /// <summary>
        /// 商户pid，唯一标识
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
