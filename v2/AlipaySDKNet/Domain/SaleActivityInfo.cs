using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SaleActivityInfo : AopObject
    {
        /// <summary>
        /// 商家券活动id。  在配券时，服务商配置的voucher_type 为 EXCHANGE_VOUCHER的活动。
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 商品单价  支付宝内部会进行金额一致性检查，每个单品的金额必须与配券时的售卖金额保持一致。  保障用户看到的单品金额与实际配券时的金额保持一致。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 购买的数量  目前暂时只能支持。一次下单购买一个商品。  后续升级后，该功能放开。
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }
    }
}
