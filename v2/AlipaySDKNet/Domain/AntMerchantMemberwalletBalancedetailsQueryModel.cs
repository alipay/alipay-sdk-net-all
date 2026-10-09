using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletBalancedetailsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletBalancedetailsQueryModel : AopObject
    {
        /// <summary>
        /// 查询结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页长
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
