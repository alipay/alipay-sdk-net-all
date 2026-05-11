using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyWelfarewalletOpenPreconsultResponse.
    /// </summary>
    public class MybankEcnyWelfarewalletOpenPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 预咨询通过返回true，反之false
        /// </summary>
        [XmlElement("allow_show")]
        public bool AllowShow { get; set; }

        /// <summary>
        /// 用于判断预咨询的情形：母子钱包都未开立，母钱包已开立子钱包未开立，以及预咨询未通过时子钱包已开立
        /// </summary>
        [XmlElement("has_wallet")]
        public bool HasWallet { get; set; }

        /// <summary>
        /// 跳转到数币阵地开户的链接
        /// </summary>
        [XmlElement("open_wallet_url")]
        public string OpenWalletUrl { get; set; }

        /// <summary>
        /// 预咨询不通过结果
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }
    }
}
