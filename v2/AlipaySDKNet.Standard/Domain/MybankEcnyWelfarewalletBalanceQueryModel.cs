using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankEcnyWelfarewalletBalanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankEcnyWelfarewalletBalanceQueryModel : AopObject
    {
        /// <summary>
        /// 固定为STKJ，商通科技简称
        /// </summary>
        [XmlElement("partner_abbr_name")]
        public string PartnerAbbrName { get; set; }

        /// <summary>
        /// 合作机构的2088编码，识别商通身份
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 福利子钱包编号
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
