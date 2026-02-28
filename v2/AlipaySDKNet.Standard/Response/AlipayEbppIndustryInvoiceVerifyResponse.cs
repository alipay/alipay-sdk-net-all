using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryInvoiceVerifyResponse.
    /// </summary>
    public class AlipayEbppIndustryInvoiceVerifyResponse : AopResponse
    {
        /// <summary>
        /// 飞机行程单信息
        /// </summary>
        [XmlElement("airplane_itinerary")]
        public InvoiceAirplaneItinerary AirplaneItinerary { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        [XmlElement("buyer_address")]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户行名称
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购买方统一信用代码，如果是个人开票不存在该字段
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        [XmlElement("buyer_telephone")]
        public string BuyerTelephone { get; set; }

        /// <summary>
        /// 发票金额，单位元
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票金额，不含税，单位元
        /// </summary>
        [XmlElement("invoice_amount_without_tax")]
        public string InvoiceAmountWithoutTax { get; set; }

        /// <summary>
        /// 发票类型
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票税额，单位元
        /// </summary>
        [XmlElement("invoice_tax_amount")]
        public string InvoiceTaxAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("invoice_item_d_t_o")]
        public List<InvoiceItemDTO> ItemList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("passenger_list")]
        [XmlArrayItem("invoice_passenger")]
        public List<InvoicePassenger> PassengerList { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销售方银行账号
        /// </summary>
        [XmlElement("seller_bank_account")]
        public string SellerBankAccount { get; set; }

        /// <summary>
        /// 销售方开户行名称
        /// </summary>
        [XmlElement("seller_bank_name")]
        public string SellerBankName { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销售方统一信用代码
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        [XmlElement("seller_telephone")]
        public string SellerTelephone { get; set; }

        /// <summary>
        /// 火车行程单信息
        /// </summary>
        [XmlElement("train_itinerary")]
        public InvoiceTrainItinerary TrainItinerary { get; set; }

        /// <summary>
        /// 发票验证结果码
        /// </summary>
        [XmlElement("verify_result_code")]
        public string VerifyResultCode { get; set; }

        /// <summary>
        /// 校验错误/不通过时参考此信息
        /// </summary>
        [XmlElement("verify_result_desc")]
        public string VerifyResultDesc { get; set; }
    }
}
