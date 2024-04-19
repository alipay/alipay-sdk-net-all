using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantMemberwalletWithdrawSubmitResponse.
    /// </summary>
    public class AntMerchantMemberwalletWithdrawSubmitResponse : AopResponse
    {
        /// <summary>
        /// 提现本金金额（单位：元）
        /// </summary>
        [XmlElement("actual_withdraw_amount")]
        public string ActualWithdrawAmount { get; set; }

        /// <summary>
        /// 提现金额（单位：元）
        /// </summary>
        [XmlElement("withdraw_amount")]
        public string WithdrawAmount { get; set; }
    }
}
