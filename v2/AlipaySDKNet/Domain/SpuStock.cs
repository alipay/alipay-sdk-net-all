using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SpuStock Data Structure.
    /// </summary>
    [Serializable]
    public class SpuStock : AopObject
    {
        /// <summary>
        /// 对用户展示的实际可售卖库存数量。 若包含了多个规格，为所有规格的可售库存之和。
        /// </summary>
        [XmlElement("available_stock_num")]
        public long AvailableStockNum { get; set; }

        /// <summary>
        /// 总库存=预扣库存+可售库存 若包含了多个规格，为所有规格的总库存之和
        /// </summary>
        [XmlElement("stock_num")]
        public long StockNum { get; set; }

        /// <summary>
        /// 用户下单但未支付的商品数量 若包含了多个规格，为所有规格的占用库存之和。
        /// </summary>
        [XmlElement("withholding_stock_num")]
        public long WithholdingStockNum { get; set; }
    }
}
