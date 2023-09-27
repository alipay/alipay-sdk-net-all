using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseExternalaccountBindGetResponse.
    /// </summary>
    public class AlipayCloudCloudbaseExternalaccountBindGetResponse : AopResponse
    {
        /// <summary>
        /// 生成的小程序accessToken
        /// </summary>
        [XmlElement("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 生成的小程序ID
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 影子钱包ID
        /// </summary>
        [XmlElement("shadow_wallet_id")]
        public string ShadowWalletId { get; set; }

        /// <summary>
        /// 绑定状态  - BIND_OK  - UNBIND_OK  - BIND_FAILED  - UNBIND_FAILED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 哈希后的用户ID
        /// </summary>
        [XmlElement("user_hash_id")]
        public string UserHashId { get; set; }

        /// <summary>
        /// 钱包签约状态
        /// </summary>
        [XmlElement("wallet_sign_status")]
        public string WalletSignStatus { get; set; }
    }
}
