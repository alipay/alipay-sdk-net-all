using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyMerchantSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyMerchantSignQueryModel : AopObject
    {
        /// <summary>
        /// 外部请求号和受理流水号两者必填一项
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 外部请求号和受理流水号两者必填一项
        /// </summary>
        [XmlElement("process_no")]
        public string ProcessNo { get; set; }

        /// <summary>
        /// 钱包ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
