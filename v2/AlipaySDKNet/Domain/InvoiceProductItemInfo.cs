using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceProductItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceProductItemInfo : AopObject
    {
        /// <summary>
        /// 商品金额,单位元，精确到分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 以元为单位精确到分。开红 票(红冲)时为负数
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品编码(或税 收分类编码)
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 部分红冲需要考虑此字段， 当红冲的商品行不是第一 行时，需要传次字段，传入 要红冲的对应的蓝票商品 行排序序号
        /// </summary>
        [XmlElement("original_blue_item_serial_no")]
        public string OriginalBlueItemSerialNo { get; set; }

        /// <summary>
        /// N:不使用，Y:使用
        /// </summary>
        [XmlElement("preferential_policy_flag")]
        public string PreferentialPolicyFlag { get; set; }

        /// <summary>
        /// 不含税单价，以元为单位精确到分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 开红票(红冲)时为 负数
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 0:正常行 1:折扣行 2:被折扣行
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 明细行号，从 1 开始
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 税额，以元为单位精确到分
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税率只能为 0 或 0.01 或 0.03 或 0.04 或 0.05 或 0.06 或 0.09 或 0.11 或 0.13 或 0.17
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 享受优惠政策标志 为 Y 时 必填 比如04 不征税
        /// </summary>
        [XmlElement("vat_special_management")]
        public string VatSpecialManagement { get; set; }

        /// <summary>
        /// 空:非零税率， 1:免税 2:不征税 3:普通零税率
        /// </summary>
        [XmlElement("zero_rate_flag")]
        public string ZeroRateFlag { get; set; }
    }
}
