using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvFundTransferResponse.
    /// </summary>
    public class AnttechBlockchainFinanceFsupvFundTransferResponse : AopResponse
    {
        /// <summary>
        /// 受理单号
        /// </summary>
        [XmlElement("accepted_no")]
        public string AcceptedNo { get; set; }

        /// <summary>
        /// 描述请求结果非已受理时的原因
        /// </summary>
        [XmlElement("mark")]
        public string Mark { get; set; }

        /// <summary>
        /// 资金划拨单状态；描述该次资金管控任务执行结果。由于合约化的资金管控划拨是异步执行，该字段只返回受理情况，资金到账情况可通过入账通知消息获取
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
