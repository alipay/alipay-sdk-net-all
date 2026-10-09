using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppEbppTransferTransferbillkeyQueryResponse.
    /// </summary>
    public class AlipayEbppEbppTransferTransferbillkeyQueryResponse : AopResponse
    {
        /// <summary>
        /// 转供户号信息集合
        /// </summary>
        [XmlArray("transfer_billkey_list")]
        [XmlArrayItem("transfer_billkey")]
        public List<TransferBillkey> TransferBillkeyList { get; set; }
    }
}
