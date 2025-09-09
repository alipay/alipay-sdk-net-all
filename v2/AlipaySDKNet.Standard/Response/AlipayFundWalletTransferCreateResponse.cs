using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundWalletTransferCreateResponse.
    /// </summary>
    public class AlipayFundWalletTransferCreateResponse : AopResponse
    {
        /// <summary>
        /// 互转单据id
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
