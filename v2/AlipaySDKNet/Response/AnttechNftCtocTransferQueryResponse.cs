using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechNftCtocTransferQueryResponse.
    /// </summary>
    public class AnttechNftCtocTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 交易状态, 枚举如下 卖家确认中-TRANSFER_CONFIRMING 卖家已经确认-TRANSFER_CONFIRMED 卖家拒绝此次交易流转-TRANSFER_REJECTED 卖家已经确认，流转中-TRANSFERRING 买家未接收，交易超时取消关单-TRANSFER_OVERDUE 流转卖家已经确认，但买家拒绝此次交易流转-RECEIVER_REJECT 流转卖家已经确认，买家完成接收-RECEIVER_ACCEPT 资产流转异常，交易取消-TRANSFER_FAILED
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
