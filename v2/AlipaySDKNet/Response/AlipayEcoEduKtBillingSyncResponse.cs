using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingSyncResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingSyncResponse : AopResponse
    {
        /// <summary>
        /// 教育缴费平台的账单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
