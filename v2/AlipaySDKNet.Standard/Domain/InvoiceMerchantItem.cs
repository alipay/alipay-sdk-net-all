using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceMerchantItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceMerchantItem : AopObject
    {
        /// <summary>
        /// 发票行性质
        /// </summary>
        [XmlElement("invoice_line_property")]
        public string InvoiceLineProperty { get; set; }

        /// <summary>
        /// 开票金额：总位数10位，最多8位整数，最多2位小数，单位：元 开票金额与不含税金额必须二选一传入，不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 不含税金额：总位数10位，最多8位整数，最多2位小数，单位：元 不含税金额与开票金额必须二选一传入 不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_amount_without_tax")]
        public string ItemAmountWithoutTax { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量：总27位数，最多17位整数，最多13位小数 不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 商品规格型号
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 商品税额：总位数20位，最多16位整数，最多2位小数，单位：元 不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 商品税率，小数介于(0, 1)，小数部分最多保留四位
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品单位，不动产经营租赁传值仅支持：平方米 成品油传值仅支持：升、吨 其他开票场景可自定义单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 含税单价：总27位数，最多17位整数，最多2位小数 单位：元 不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 不含税单价：总27位数，最多17位整数，最多2位小数 单位：元 不传入则系统自行计算，传入则只做校验
        /// </summary>
        [XmlElement("item_unit_amount_without_tax")]
        public string ItemUnitAmountWithoutTax { get; set; }

        /// <summary>
        /// 关联蓝票明细行序号，红冲时使用原始发票对应的明细行序号
        /// </summary>
        [XmlElement("related_blue_serial_no")]
        public long RelatedBlueSerialNo { get; set; }

        /// <summary>
        /// 明细行序号
        /// </summary>
        [XmlElement("serial_no")]
        public long SerialNo { get; set; }

        /// <summary>
        /// 税收分类编码，请参考标准商品税编列表填写
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }
    }
}
