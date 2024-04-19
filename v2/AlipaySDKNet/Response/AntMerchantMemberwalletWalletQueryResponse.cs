using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletWalletQueryResponse.
    /// </summary>
    public class AntMerchantMemberwalletWalletQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已开户
        /// </summary>
        [XmlElement("open")]
        public bool Open { get; set; }

        /// <summary>
        /// 会员钱包开户时间
        /// </summary>
        [XmlElement("open_time")]
        public string OpenTime { get; set; }

        /// <summary>
        /// 会员钱包开户url
        /// </summary>
        [XmlElement("open_url")]
        public string OpenUrl { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
