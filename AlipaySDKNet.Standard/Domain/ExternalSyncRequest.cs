using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalSyncRequest : AopObject
    {
        /// <summary>
        /// 支付宝账单ID
        /// </summary>
        [XmlElement("alipay_bill_id")]
        public string AlipayBillId { get; set; }

        /// <summary>
        /// 外部账单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
