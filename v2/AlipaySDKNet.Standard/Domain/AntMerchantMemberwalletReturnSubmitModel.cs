using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantMemberwalletReturnSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantMemberwalletReturnSubmitModel : AopObject
    {
        /// <summary>
        /// 会员钱包产品ID
        /// </summary>
        [XmlElement("member_wallet_id")]
        public string MemberWalletId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 可退卡余额（单位：元）
        /// </summary>
        [XmlElement("return_amount")]
        public string ReturnAmount { get; set; }

        /// <summary>
        /// 会员钱包账户ID
        /// </summary>
        [XmlElement("wallet_id")]
        public string WalletId { get; set; }
    }
}
