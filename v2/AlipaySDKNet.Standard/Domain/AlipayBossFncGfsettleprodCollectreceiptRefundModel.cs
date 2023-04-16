using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodCollectreceiptRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncGfsettleprodCollectreceiptRefundModel : AopObject
    {
        /// <summary>
        /// 收款单退款申请请求
        /// </summary>
        [XmlElement("collect_receipt_refund_apply_order")]
        public CollectReceiptRefundApplyOrder CollectReceiptRefundApplyOrder { get; set; }
    }
}
