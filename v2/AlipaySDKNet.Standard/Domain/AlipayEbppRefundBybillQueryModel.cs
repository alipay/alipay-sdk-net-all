using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppRefundBybillQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppRefundBybillQueryModel : AopObject
    {
        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }
    }
}
