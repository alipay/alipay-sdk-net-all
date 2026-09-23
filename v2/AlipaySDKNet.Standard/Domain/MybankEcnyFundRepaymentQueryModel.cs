using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyFundRepaymentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyFundRepaymentQueryModel : AopObject
    {
        /// <summary>
        /// 调用方编码
        /// </summary>
        [XmlElement("out_request_from")]
        public string OutRequestFrom { get; set; }

        /// <summary>
        /// 外部平台全局唯一流水号
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 预付回款业务的回款方钱包，对应专户发薪收款钱包
        /// </summary>
        [XmlElement("payer_wallet_id")]
        public string PayerWalletId { get; set; }
    }
}
