using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObcInvoiceApplyLineRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ObcInvoiceApplyLineRequest : AopObject
    {
        /// <summary>
        /// 货币单位，必填
        /// </summary>
        [XmlElement("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 金额的String类型，CNY币种下单位为元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 具体服务或货物的规则型号
        /// </summary>
        [XmlElement("invoice_specification")]
        public string InvoiceSpecification { get; set; }

        /// <summary>
        /// 金额的String类型，CNY币种下单位为元，单价*数量=金额
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 开票明细行的货物或服务名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 数量，小数点后最多保留4位，单价*数量=金额
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 金额的String类型，单位元，必填
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 国内税率一般为6%，13%，这里是百分号前的部分
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 提供服务或商品的单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
