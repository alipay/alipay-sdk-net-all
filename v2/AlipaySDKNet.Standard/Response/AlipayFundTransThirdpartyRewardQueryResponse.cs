using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransThirdpartyRewardQueryResponse.
    /// </summary>
    public class AlipayFundTransThirdpartyRewardQueryResponse : AopResponse
    {
        /// <summary>
        /// 打赏金额，单位：人民币分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 打赏未成功时的错误原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 打赏时间，毫秒数
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }

        /// <summary>
        /// 被打赏用户支付宝UserId
        /// </summary>
        [XmlElement("receiver_user_id")]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 打赏用户支付宝UserId
        /// </summary>
        [XmlElement("sender_user_id")]
        public string SenderUserId { get; set; }

        /// <summary>
        /// 打赏状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 转账单据号
        /// </summary>
        [XmlElement("transfer_no")]
        public string TransferNo { get; set; }
    }
}
