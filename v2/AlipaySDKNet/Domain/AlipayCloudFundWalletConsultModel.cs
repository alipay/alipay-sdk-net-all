using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudFundWalletConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudFundWalletConsultModel : AopObject
    {
        /// <summary>
        /// 查询不同场景信息 WALLET_INFO：查用户钱包
        /// </summary>
        [XmlElement("search_type")]
        public string SearchType { get; set; }

        /// <summary>
        /// user_wallet_id
        /// </summary>
        [XmlElement("user_wallet_id")]
        public string UserWalletId { get; set; }
    }
}
