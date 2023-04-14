using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VoucherExchangeGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherExchangeGoodsInfo : AopObject
    {
        /// <summary>
        /// 兑换商品名称
        /// </summary>
        [XmlElement("exchange_goods_name")]
        public string ExchangeGoodsName { get; set; }
    }
}
