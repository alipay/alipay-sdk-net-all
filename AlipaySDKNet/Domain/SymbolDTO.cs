using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SymbolDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SymbolDTO : AopObject
    {
        /// <summary>
        /// 股票code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 成交单位
        /// </summary>
        [XmlElement("hand")]
        public long Hand { get; set; }

        /// <summary>
        /// 成交单位
        /// </summary>
        [XmlElement("hand_unit")]
        public string HandUnit { get; set; }

        /// <summary>
        /// 上市状态：commons-push-model/src/main/proto/model/symbol.proto
        /// </summary>
        [XmlElement("list_type")]
        public string ListType { get; set; }

        /// <summary>
        /// 市场
        /// </summary>
        [XmlElement("market")]
        public string Market { get; set; }

        /// <summary>
        /// 股票名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 报价单位精度
        /// </summary>
        [XmlElement("price_decimal")]
        public long PriceDecimal { get; set; }

        /// <summary>
        /// 股票子类型
        /// </summary>
        [XmlElement("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 股票唯一代码，symbol=code.market
        /// </summary>
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// 股票类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
