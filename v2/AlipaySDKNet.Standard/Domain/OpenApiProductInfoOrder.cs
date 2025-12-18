using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiProductInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiProductInfoOrder : AopObject
    {
        /// <summary>
        /// 含税金额, 等于 不含税金额 * ( 1 + 税率 ) 与不含税金额二选一必填, 推荐填含税金额
        /// </summary>
        [XmlElement("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 货物或劳务名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 不含税金额, 等于 含税金额 / ( 1 + 税率 ) 与含税金额二选一必填, 推荐填写含税金额
        /// </summary>
        [XmlElement("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }
    }
}
