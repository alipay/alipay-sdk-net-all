using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceRevAmountDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceRevAmountDTO : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 无票金额
        /// </summary>
        [XmlElement("no_vat_receiveable_amount")]
        public MultiCurrencyMoneyOpenApi NoVatReceiveableAmount { get; set; }

        /// <summary>
        /// 无票税损金额
        /// </summary>
        [XmlElement("no_vat_tax_loss_amount")]
        public MultiCurrencyMoneyOpenApi NoVatTaxLossAmount { get; set; }

        /// <summary>
        /// 发票税损比例
        /// </summary>
        [XmlElement("no_vat_tax_loss_rate")]
        public string NoVatTaxLossRate { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 可收票金额
        /// </summary>
        [XmlElement("receiveable_amount")]
        public MultiCurrencyMoneyOpenApi ReceiveableAmount { get; set; }

        /// <summary>
        /// 普票可收款金额
        /// </summary>
        [XmlElement("vat_nomal_receiveable_amount")]
        public MultiCurrencyMoneyOpenApi VatNomalReceiveableAmount { get; set; }

        /// <summary>
        /// 普票税损金额
        /// </summary>
        [XmlElement("vat_nomal_tax_loss_amount")]
        public MultiCurrencyMoneyOpenApi VatNomalTaxLossAmount { get; set; }

        /// <summary>
        /// 普票税损比例
        /// </summary>
        [XmlElement("vat_nomal_tax_loss_rate")]
        public string VatNomalTaxLossRate { get; set; }

        /// <summary>
        /// 专票可收款金额
        /// </summary>
        [XmlElement("vat_special_receiveable_amount")]
        public MultiCurrencyMoneyOpenApi VatSpecialReceiveableAmount { get; set; }
    }
}
