using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundCardGenerateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCardGenerateCreateModel : AopObject
    {
        /// <summary>
        /// 扣款协议号，安全发场景必填
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码，DEPOSIT_CERT：充值凭证
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 制卡资金来源：默认ACCOUNT_BOOK
        /// </summary>
        [XmlElement("fund_source")]
        public string FundSource { get; set; }

        /// <summary>
        /// 资金来源凭证：ACCOUNT_BOOK模式下为子户号
        /// </summary>
        [XmlElement("fund_source_cert")]
        public string FundSourceCert { get; set; }

        /// <summary>
        /// 制卡单据明细，本期仅支持一条明细
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("fund_card_generate_order")]
        public List<FundCardGenerateOrder> OrderList { get; set; }

        /// <summary>
        /// 外部单号，幂等用
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
