using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTransferQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvTransferQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金划拨受理后生产的流水
        /// </summary>
        [XmlElement("accepted_no")]
        public string AcceptedNo { get; set; }

        /// <summary>
        /// 资金管控任务编号
        /// </summary>
        [XmlElement("fund_supv_task_id")]
        public string FundSupvTaskId { get; set; }

        /// <summary>
        /// 资金管控专户号
        /// </summary>
        [XmlElement("supv_special_account_no")]
        public string SupvSpecialAccountNo { get; set; }

        /// <summary>
        /// 划拨说明
        /// </summary>
        [XmlElement("transfer_desc")]
        public string TransferDesc { get; set; }

        /// <summary>
        /// 划拨明细，描述划拨金额及状态
        /// </summary>
        [XmlArray("transfer_detail")]
        [XmlArrayItem("supv_fund_transfer_detail")]
        public List<SupvFundTransferDetail> TransferDetail { get; set; }

        /// <summary>
        /// 划拨状态
        /// </summary>
        [XmlElement("transfer_status")]
        public string TransferStatus { get; set; }
    }
}
