using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsFreightflowSubaccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsFreightflowSubaccountQueryModel : AopObject
    {
        /// <summary>
        /// 物流公司编码，由支付宝分配
        /// </summary>
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 银行管理模式。 本期： ANT_MYBANK(网商银行模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 如果mode为网商银行，则为网商银行分配
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 子户卡号
        /// </summary>
        [XmlElement("sub_bank_card_no")]
        public string SubBankCardNo { get; set; }
    }
}
