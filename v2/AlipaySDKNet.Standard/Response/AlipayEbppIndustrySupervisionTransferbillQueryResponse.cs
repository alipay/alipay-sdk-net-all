using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustrySupervisionTransferbillQueryResponse.
    /// </summary>
    public class AlipayEbppIndustrySupervisionTransferbillQueryResponse : AopResponse
    {
        /// <summary>
        /// 资金划拨账单列表
        /// </summary>
        [XmlArray("transfer_bill_list")]
        [XmlArrayItem("supervision_order_transfer_bill_info")]
        public List<SupervisionOrderTransferBillInfo> TransferBillList { get; set; }
    }
}
