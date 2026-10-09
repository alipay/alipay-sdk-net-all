using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceLineInfoOrder Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceLineInfoOrder : AopObject
    {
        /// <summary>
        /// 免税标记 Y:免税 N：不免税 税率为零时必须指定
        /// </summary>
        [XmlElement("duty_free_flag")]
        public string DutyFreeFlag { get; set; }

        /// <summary>
        /// 免税类型；00：出口零税率，01：免税；02：不征收；03：普通零税率
        /// </summary>
        [XmlElement("duty_free_type")]
        public string DutyFreeType { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [XmlElement("line_amt")]
        public MultiCurrencyMoneyOpenApi LineAmt { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [XmlElement("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 打印在发票上面的发票行的商品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 税率，免税的时候传0
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 数量和单价不能同时存在
        /// </summary>
        [XmlElement("unit_amt")]
        public string UnitAmt { get; set; }
    }
}
