using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderPriceParam Data Structure.
    /// </summary>
    [Serializable]
    public class OrderPriceParam : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("order_amount")]
        public MultiCurrencyMoneyDTO OrderAmount { get; set; }

        /// <summary>
        /// 供应商优惠金额
        /// </summary>
        [XmlElement("supplier_discount")]
        public MultiCurrencyMoneyDTO SupplierDiscount { get; set; }
    }
}
