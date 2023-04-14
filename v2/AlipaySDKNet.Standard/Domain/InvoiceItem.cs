using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceItem : AopObject
    {
        /// <summary>
        /// 含税总金额 (等于sum_price和tax之和)， 单位：元，格式为2位小数，精度2位小数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票项目名称（或商品名称）
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 发票项目编号（或商品编号）
        /// </summary>
        [XmlElement("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 单价（不含税），格式为2位小数。最大支持6位小数，不足2位小数时需转化为2位小数格式。 折扣行此参数不能传
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量，须大于0，最多6位小数。 折扣行此参数不能传
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。 比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0。
        /// </summary>
        [XmlElement("row_type")]
        public long RowType { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 不含税总金额，格式为2位小数 单位：元，精度2位小数
        /// </summary>
        [XmlElement("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额， 格式为2位小数
        /// </summary>
        [XmlElement("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// 税率。格式为2位小数，如：0.00, 0.03, 0.13等等
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单位，折扣行不能传
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 0税率标识，只有税率为0的情况才有值，0=出口零税率，1=免税，2=不征收，3=普通零税率
        /// </summary>
        [XmlElement("zero_rate_flag")]
        public string ZeroRateFlag { get; set; }
    }
}
