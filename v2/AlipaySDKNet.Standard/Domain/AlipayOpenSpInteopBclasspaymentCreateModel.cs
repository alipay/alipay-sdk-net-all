using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpInteopBclasspaymentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpInteopBclasspaymentCreateModel : AopObject
    {
        /// <summary>
        /// 银行卡信息
        /// </summary>
        [XmlElement("bank_card_info")]
        public BClassPaymentBankCardInfo BankCardInfo { get; set; }

        /// <summary>
        /// 商家联系方式
        /// </summary>
        [XmlElement("contact_info")]
        public BClassPaymentContactInfo ContactInfo { get; set; }

        /// <summary>
        /// 一体化作业开通主单号，单号为服务商一体化作业主单创建返回值。
        /// </summary>
        [XmlElement("inteop_order_no")]
        public string InteopOrderNo { get; set; }

        /// <summary>
        /// 商家经营类目编码。参见 <a href="https://opendocs.alipay.com/common/02khjv">商家经营类目2.0</a> 中的“一级类目code_二级类目code”。
        /// </summary>
        [XmlElement("mcc_code")]
        public string MccCode { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
