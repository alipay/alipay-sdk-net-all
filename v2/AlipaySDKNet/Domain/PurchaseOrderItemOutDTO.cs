using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseOrderItemOutDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseOrderItemOutDTO : AopObject
    {
        /// <summary>
        /// 地址扩展信息
        /// </summary>
        [XmlElement("address_ext")]
        public string AddressExt { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address_id")]
        public string AddressId { get; set; }

        /// <summary>
        /// 收货地址信息
        /// </summary>
        [XmlElement("address_info")]
        public string AddressInfo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 采购类目code
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 采购用途
        /// </summary>
        [XmlElement("category_use")]
        public string CategoryUse { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 数据来源（内部字段）
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 需求方
        /// </summary>
        [XmlElement("demander")]
        public string Demander { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// ext_object
        /// </summary>
        [XmlElement("ext_object")]
        public string ExtObject { get; set; }

        /// <summary>
        /// 商品报价ID
        /// </summary>
        [XmlElement("goods_quotation_id")]
        public string GoodsQuotationId { get; set; }

        /// <summary>
        /// 订单行ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 国际贸易术语
        /// </summary>
        [XmlElement("incoterm")]
        public string Incoterm { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 是否按资产管理
        /// </summary>
        [XmlElement("is_detail_by_asset_management")]
        public bool IsDetailByAssetManagement { get; set; }

        /// <summary>
        /// 是否按照明细下单
        /// </summary>
        [XmlElement("is_po_by_detail")]
        public bool IsPoByDetail { get; set; }

        /// <summary>
        /// 物品描述
        /// </summary>
        [XmlElement("item_description")]
        public string ItemDescription { get; set; }

        /// <summary>
        /// 物品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 行号
        /// </summary>
        [XmlElement("line_num")]
        public long LineNum { get; set; }

        /// <summary>
        /// 寻源修改的类目
        /// </summary>
        [XmlElement("modified_category_code")]
        public string ModifiedCategoryCode { get; set; }

        /// <summary>
        /// 期望交付日期终
        /// </summary>
        [XmlElement("need_by_date_end")]
        public string NeedByDateEnd { get; set; }

        /// <summary>
        /// 期望交付日期始
        /// </summary>
        [XmlElement("need_by_date_start")]
        public string NeedByDateStart { get; set; }

        /// <summary>
        /// 购买方式
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 原始含税金额
        /// </summary>
        [XmlElement("origin_tax_amount")]
        public string OriginTaxAmount { get; set; }

        /// <summary>
        /// 原始含税单价
        /// </summary>
        [XmlElement("origin_tax_unit_price")]
        public string OriginTaxUnitPrice { get; set; }

        /// <summary>
        /// 采购申请单行编号
        /// </summary>
        [XmlElement("pr_item_number")]
        public string PrItemNumber { get; set; }

        /// <summary>
        /// 申请单编号
        /// </summary>
        [XmlElement("pr_number")]
        public string PrNumber { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 项目编号
        /// </summary>
        [XmlElement("project_number")]
        public string ProjectNumber { get; set; }

        /// <summary>
        /// 采购订单id
        /// </summary>
        [XmlElement("purchase_order_id")]
        public string PurchaseOrderId { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 接收已使用（计算公式：已接收+接收中-已退货）
        /// </summary>
        [XmlElement("quantity_received")]
        public string QuantityReceived { get; set; }

        /// <summary>
        /// 报价单行编码
        /// </summary>
        [XmlElement("quotation_item_number")]
        public string QuotationItemNumber { get; set; }

        /// <summary>
        /// 已接收金额
        /// </summary>
        [XmlElement("received")]
        public string Received { get; set; }

        /// <summary>
        /// 接收人员工编码
        /// </summary>
        [XmlElement("receiver")]
        public string Receiver { get; set; }

        /// <summary>
        /// 产品SKU的ID
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 规格属性
        /// </summary>
        [XmlElement("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 需求表单号
        /// </summary>
        [XmlElement("sr_number")]
        public string SrNumber { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 含税金额
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 税码
        /// </summary>
        [XmlElement("tax_code")]
        public string TaxCode { get; set; }

        /// <summary>
        /// 税码描述
        /// </summary>
        [XmlElement("tax_code_desc")]
        public string TaxCodeDesc { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 含税单价
        /// </summary>
        [XmlElement("tax_unit_price")]
        public string TaxUnitPrice { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [XmlElement("uom")]
        public string Uom { get; set; }
    }
}
