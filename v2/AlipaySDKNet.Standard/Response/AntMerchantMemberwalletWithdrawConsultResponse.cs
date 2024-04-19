using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletWithdrawConsultResponse.
    /// </summary>
    public class AntMerchantMemberwalletWithdrawConsultResponse : AopResponse
    {
        /// <summary>
        /// 实际可提现本金金额（单位：元）
        /// </summary>
        [XmlElement("actual_available_withdraw_amount")]
        public string ActualAvailableWithdrawAmount { get; set; }

        /// <summary>
        /// 提现金额（单位：元）
        /// </summary>
        [XmlElement("available_withdraw_amount")]
        public string AvailableWithdrawAmount { get; set; }
    }
}
