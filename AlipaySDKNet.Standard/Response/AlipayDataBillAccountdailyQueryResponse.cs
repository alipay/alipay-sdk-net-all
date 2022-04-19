using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillAccountdailyQueryResponse.
    /// </summary>
    public class AlipayDataBillAccountdailyQueryResponse : AopResponse
    {
        /// <summary>
        /// 当日充值金额
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 当日转入金额
        /// </summary>
        [XmlElement("trans_in_amount")]
        public string TransInAmount { get; set; }

        /// <summary>
        /// 当日转出余额
        /// </summary>
        [XmlElement("trans_out_amount")]
        public string TransOutAmount { get; set; }

        /// <summary>
        /// 当日提现金额
        /// </summary>
        [XmlElement("withdraw_amount")]
        public string WithdrawAmount { get; set; }
    }
}
