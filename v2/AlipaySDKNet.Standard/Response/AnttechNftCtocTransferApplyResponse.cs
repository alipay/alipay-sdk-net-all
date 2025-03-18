using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocTransferApplyResponse.
    /// </summary>
    public class AnttechNftCtocTransferApplyResponse : AopResponse
    {
        /// <summary>
        /// 业务单号
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 交易状态 失败:TRANSFER_FAILED 转赠发起确认中:TRANSFER_CONFIRMING 已转赠成功:TRANSFER_ACCEPT
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
