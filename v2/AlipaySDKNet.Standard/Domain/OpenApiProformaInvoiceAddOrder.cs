using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenApiProformaInvoiceAddOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OpenApiProformaInvoiceAddOrder : AopObject
    {
        /// <summary>
        /// 调用方身份识别标记, 一般为系统名, 与业务单据号联合唯一
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务单据号 必填
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 可选, 购方邮箱地址, 会放在开出发票的拓展信息, 后续邮寄使用,多个邮箱使用英文逗号连接
        /// </summary>
        [XmlElement("buyer_contact_email")]
        public string BuyerContactEmail { get; set; }

        /// <summary>
        /// 可选, 购买方国家/地区, ISO 3166的两位英文编码
        /// </summary>
        [XmlElement("buyer_country")]
        public string BuyerCountry { get; set; }

        /// <summary>
        /// 购方信息
        /// </summary>
        [XmlElement("buyer_info")]
        public OpenApiBuyerInvoiceInfoOrder BuyerInfo { get; set; }

        /// <summary>
        /// 可选, 购方OU, 关交场景查询收款账户时使用
        /// </summary>
        [XmlElement("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// 收款币种, 非必填 查询销方银行账户信息时使用, 不传则默认使用priceCcy
        /// </summary>
        [XmlElement("collect_ccy")]
        public string CollectCcy { get; set; }

        /// <summary>
        /// 可选, 是否免税 默认N TaxInvoice+0税率+免税 = debitNote, 即票面不展示税额行 TaxInvoice+0税率+不免税, 票面会展示0税额行
        /// </summary>
        [XmlElement("duty_free")]
        public string DutyFree { get; set; }

        /// <summary>
        /// 费用结束日期  格式(yyyyMMdd), 若传入则与费用开始日期必须同时存在,  优先级比外部的格式化费用期间feeIntervalFormatStr低 三者都不传则默认取当月
        /// </summary>
        [XmlElement("fee_end_dt")]
        public string FeeEndDt { get; set; }

        /// <summary>
        /// 外部单据传入的用于票面显示的费用期间, 多区间格式化字符串, 使用空格连接 优先级比 费用开始与结束时间高, 都不传则默认当月
        /// </summary>
        [XmlElement("fee_interval_format_str")]
        public string FeeIntervalFormatStr { get; set; }

        /// <summary>
        /// 费用开始日期  格式(yyyyMMdd), 若传入则与费用结束日期必须同时存在,  优先级比外部的格式化费用期间feeIntervalFormatStr低 三者都不传则默认取当月
        /// </summary>
        [XmlElement("fee_start_dt")]
        public string FeeStartDt { get; set; }

        /// <summary>
        /// 开票日期, 格式(yyyyMMdd), 不传默认当天
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 可选, 展示在票面的备注
        /// </summary>
        [XmlElement("invoice_note")]
        public string InvoiceNote { get; set; }

        /// <summary>
        /// 发票类型code
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 本地币种, 非必填, 不传时由发票根据ou进行查询 计价币种与当地币种不一致的时候, 需要进行汇率换算, 符合条件的OU会展示税金折算在票面上
        /// </summary>
        [XmlElement("local_ccy")]
        public string LocalCcy { get; set; }

        /// <summary>
        /// 可选, 申请原因, 保存在申请表中, 不展示在票面
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 可选, 申请开票方式, 默认为02, InvoiceOrderWayEnum的code
        /// </summary>
        [XmlElement("order_way")]
        public string OrderWay { get; set; }

        /// <summary>
        /// 可选, 销方收款账号信息, 不传则以下面的信息进行查询: 销方OU 价格币种 购方国家地区 购方OU(关交)
        /// </summary>
        [XmlElement("payment_method_order")]
        public OpenApiPaymentMethodOrder PaymentMethodOrder { get; set; }

        /// <summary>
        /// 商品计价币种, 多币种类MultiCurrencyMoney的currencyValue
        /// </summary>
        [XmlElement("price_ccy")]
        public string PriceCcy { get; set; }

        /// <summary>
        /// 商品信息
        /// </summary>
        [XmlArray("product_info_orders")]
        [XmlArrayItem("open_api_product_info_order")]
        public List<OpenApiProductInfoOrder> ProductInfoOrders { get; set; }

        /// <summary>
        /// 可选, 资金是否收回 默认N 未收回才会在票面展示付款银行账户信息
        /// </summary>
        [XmlElement("received")]
        public string Received { get; set; }

        /// <summary>
        /// 销方信息
        /// </summary>
        [XmlElement("seller_info")]
        public OpenApiSellerInvoiceInfoOrder SellerInfo { get; set; }

        /// <summary>
        /// 税率, 小于1的两位小数字符串, 例如0.06 0.08, 不带有如%之类的符号
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 可选, 传具体税种如GST/VAT, 不传则默认填充01后台进行税种匹配. 本字段并非可拓展字段设计, 只是用于国际无账单开票的票面展示, 而这种场景税种的填写比较自由, 比如企业所得税corporate income tax, 可以直接填也可以缩写为CIT, 也可以是EIT, 所以无法全部枚举列出.
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 可选, 是否无账单, 默认Y
        /// </summary>
        [XmlElement("without_bill")]
        public string WithoutBill { get; set; }
    }
}
