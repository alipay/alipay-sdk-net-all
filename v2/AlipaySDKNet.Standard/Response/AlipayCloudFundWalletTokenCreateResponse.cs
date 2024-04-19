using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundWalletTokenCreateResponse.
    /// </summary>
    public class AlipayCloudFundWalletTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 绑定凭证
        /// </summary>
        [XmlElement("bind_token")]
        public string BindToken { get; set; }

        /// <summary>
        /// 用户开通钱包链接
        /// </summary>
        [XmlElement("bind_url")]
        public string BindUrl { get; set; }

        /// <summary>
        /// 用户若已开通过钱包，会幂等返回用户钱包ID
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
