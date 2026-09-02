using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemoteExternalBillGroupInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RemoteExternalBillGroupInfo : AopObject
    {
        /// <summary>
        /// 分组标题
        /// </summary>
        [XmlElement("bill_info_title")]
        public string BillInfoTitle { get; set; }

        /// <summary>
        /// 账单明细
        /// </summary>
        [XmlArray("external_bill_details")]
        [XmlArrayItem("remote_external_bill_detail")]
        public List<RemoteExternalBillDetail> ExternalBillDetails { get; set; }

        /// <summary>
        /// 分组总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
