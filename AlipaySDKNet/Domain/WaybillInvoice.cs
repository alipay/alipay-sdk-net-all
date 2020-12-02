using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WaybillInvoice Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillInvoice : AopObject
    {
        /// <summary>
        /// 即时配送运单金额
        /// </summary>
        [XmlElement("waybill_amount")]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        [XmlElement("waybill_no")]
        public string WaybillNo { get; set; }
    }
}
