using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenInvoiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class OpenInvoiceItem : AopObject
    {
        /// <summary>
        /// 商品单价（元）
        /// </summary>
        [XmlElement("item_amount")]
        public string ItemAmount { get; set; }

        /// <summary>
        /// 商品货物/服务名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("item_num")]
        public string ItemNum { get; set; }

        /// <summary>
        /// 商品规格
        /// </summary>
        [XmlElement("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 商品税额（元）
        /// </summary>
        [XmlElement("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 商品税率
        /// </summary>
        [XmlElement("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 商品总价（元）
        /// </summary>
        [XmlElement("item_total_amount")]
        public string ItemTotalAmount { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }
    }
}
