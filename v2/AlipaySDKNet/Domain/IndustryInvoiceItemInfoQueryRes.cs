using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceItemInfoQueryRes Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceItemInfoQueryRes : AopObject
    {
        /// <summary>
        /// 优惠政策标识
        /// </summary>
        [XmlElement("favoured_policy_flag")]
        public string FavouredPolicyFlag { get; set; }

        /// <summary>
        /// 发票行性质
        /// </summary>
        [XmlElement("invoice_line_property")]
        public string InvoiceLineProperty { get; set; }

        /// <summary>
        /// 开票金额：总位数20位，最多16位整数，最多2位小数，单位：元
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 税收分类编码简称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// 商品配置编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量：总位数26位，最多15整数,10小数
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 税额，单位：元
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 商品税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 关联蓝票明细行序号
        /// </summary>
        [XmlElement("related_blue_serial_no")]
        public long RelatedBlueSerialNo { get; set; }

        /// <summary>
        /// 明细行序号
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 税收分类编码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
