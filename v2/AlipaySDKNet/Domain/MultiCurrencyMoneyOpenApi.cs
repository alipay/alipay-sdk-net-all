using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyOpenApi Data Structure.
    /// </summary>
    [Serializable]
    public class MultiCurrencyMoneyOpenApi : AopObject
    {
        /// <summary>
        /// 表示金额中的分，为该货币的最小单位, 如人民币中的分、美元中的美分, 韩元日元中的元等, 具体换算比例在多币种类MultiCurrencyMoney中有字段digits
        /// </summary>
        [XmlElement("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }
    }
}
