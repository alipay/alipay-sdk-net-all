using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaoInvoiceDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaoInvoiceDetail : AopObject
    {
        /// <summary>
        /// 验收数量（次）
        /// </summary>
        [XmlElement("acceptance_count")]
        public string AcceptanceCount { get; set; }

        /// <summary>
        /// 验收时间
        /// </summary>
        [XmlElement("acceptance_date")]
        public string AcceptanceDate { get; set; }

        /// <summary>
        /// 验收情况
        /// </summary>
        [XmlElement("acceptance_status")]
        public string AcceptanceStatus { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("commodity_code")]
        public string CommodityCode { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("commodity_count")]
        public string CommodityCount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 首年维保结束时间
        /// </summary>
        [XmlElement("first_year_warranty_end_date")]
        public string FirstYearWarrantyEndDate { get; set; }

        /// <summary>
        /// 首年维保开始时间
        /// </summary>
        [XmlElement("first_year_warranty_start_date")]
        public string FirstYearWarrantyStartDate { get; set; }

        /// <summary>
        /// 关联【总代发货单】
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发货单明细自增编号
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 节点数
        /// </summary>
        [XmlElement("node_count")]
        public string NodeCount { get; set; }

        /// <summary>
        /// 价格含税元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        [XmlElement("product_category")]
        public string ProductCategory { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 售卖单位
        /// </summary>
        [XmlElement("selling_unit")]
        public string SellingUnit { get; set; }

        /// <summary>
        /// SKU名称
        /// </summary>
        [XmlElement("sku_name")]
        public string SkuName { get; set; }

        /// <summary>
        /// SKU编码
        /// </summary>
        [XmlElement("sku_no")]
        public string SkuNo { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 使用年限
        /// </summary>
        [XmlElement("years_count")]
        public string YearsCount { get; set; }
    }
}
