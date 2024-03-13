using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTransferQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvTransferQueryModel : AopObject
    {
        /// <summary>
        /// 受理号，即管控账户资金划拨响应中返回的受理号
        /// </summary>
        [XmlElement("accepted_no")]
        public string AcceptedNo { get; set; }

        /// <summary>
        /// 申请资金划拨时上传的流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
