using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseInvoiceItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseInvoiceItemDTO : AopObject
    {
        /// <summary>
        /// 价税合计。格式为2位小数，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票项目名称/货物名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 商品单价。单位为元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 总价 (不含税)。格式为2位小数，单位为元
        /// </summary>
        [XmlElement("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额。格式为2位小数，单位为元
        /// </summary>
        [XmlElement("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// 税率。格式为2位小数，如：0.00, 0.03, 0.13
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }
    }
}
