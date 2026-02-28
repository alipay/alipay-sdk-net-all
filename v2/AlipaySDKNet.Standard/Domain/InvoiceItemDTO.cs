using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceItemDTO : AopObject
    {
        /// <summary>
        /// 金额，单位：元
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 商品服务简称
        /// </summary>
        [XmlElement("item_category_name")]
        public string ItemCategoryName { get; set; }

        /// <summary>
        /// 项目名称
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
        /// 税额，单位：元
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 含税金额，单位：元
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价，单位：元
        /// </summary>
        [XmlElement("item_unit_amount")]
        public string ItemUnitAmount { get; set; }

        /// <summary>
        /// 明细序号
        /// </summary>
        [XmlElement("serial_no")]
        public string SerialNo { get; set; }
    }
}
