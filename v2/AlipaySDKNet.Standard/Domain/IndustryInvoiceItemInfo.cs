using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IndustryInvoiceItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IndustryInvoiceItemInfo : AopObject
    {
        /// <summary>
        /// 优惠政策标识
        /// </summary>
        [XmlElement("favoured_policy_flag")]
        public string FavouredPolicyFlag { get; set; }

        /// <summary>
        /// 明细行总开票金额(单位:元)，总和小于等于账单金额 当前字段已废弃(字段调整为item_amount，此字段不做处理)
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票行性质，仅支持 正常行-NORMAL_LINE
        /// </summary>
        [XmlElement("invoice_line_property")]
        public string InvoiceLineProperty { get; set; }

        /// <summary>
        /// 开票金额：总位数20位，最多16位整数，最多2位小数，单位：元
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

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
        /// 商品数量：总27位数，最多15位整数，最多10位小数
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 商品规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 商品税率，小数介于(0, 1)，小数部分最多保留四位
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品单位 不动产经营租赁传值仅支持：平方米 成品油传值仅支持：升、吨 其他开票场景可自定义单位
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
