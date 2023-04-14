using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceContentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceContentInfo : AopObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票项目名称/货物名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品编码/税收分类编码
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行
        /// </summary>
        [XmlElement("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [XmlElement("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [XmlElement("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 税率标识，只有税率为0的情况才有值，0=出口零税率，1=免税，2=不征收，3=普通零税率
        /// </summary>
        [XmlElement("zero_rate_flag")]
        public string ZeroRateFlag { get; set; }
    }
}
