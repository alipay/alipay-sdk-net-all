using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderInvoiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class OrderInvoiceItem : AopObject
    {
        /// <summary>
        /// 优惠政策标识
        /// </summary>
        [XmlElement("favoured_policy_flag")]
        public string FavouredPolicyFlag { get; set; }

        /// <summary>
        /// 行性质
        /// </summary>
        [XmlElement("invoice_line_property")]
        public string InvoiceLineProperty { get; set; }

        /// <summary>
        /// 不含税金额，计量单位：人民币
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 分类简称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 税额，计量单位：人民币
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("item_tax_code")]
        public string ItemTaxCode { get; set; }

        /// <summary>
        /// 税率，以小数形式展示
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 含税金额，计量单位：人民币
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价，计量单位：人民币
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 开具红字发票时，明细对应红冲的蓝字发票明细序号
        /// </summary>
        [XmlElement("related_blue_serial_no")]
        public long RelatedBlueSerialNo { get; set; }

        /// <summary>
        /// 明细序号
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }
    }
}
