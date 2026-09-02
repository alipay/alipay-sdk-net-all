using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemoteExternalYearBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RemoteExternalYearBillInfo : AopObject
    {
        /// <summary>
        /// 账单明细
        /// </summary>
        [XmlArray("external_bill_details")]
        [XmlArrayItem("remote_external_bill_detail")]
        public List<RemoteExternalBillDetail> ExternalBillDetails { get; set; }

        /// <summary>
        /// 年分组总金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 年份
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
