using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceApplyItems Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceApplyItems : AopObject
    {
        /// <summary>
        /// 商品明细金额
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 开票商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量，按开票金额除以含税单价计
        /// </summary>
        [XmlElement("item_quantity")]
        public string ItemQuantity { get; set; }

        /// <summary>
        /// 开票商品的规格或型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 开票商品对应的税收分类编码
        /// </summary>
        [XmlElement("item_tax_code")]
        public string ItemTaxCode { get; set; }

        /// <summary>
        /// 商品适用税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 开票商品计量单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 商品含税单价
        /// </summary>
        [XmlElement("item_unit_amount_with_tax")]
        public string ItemUnitAmountWithTax { get; set; }
    }
}
