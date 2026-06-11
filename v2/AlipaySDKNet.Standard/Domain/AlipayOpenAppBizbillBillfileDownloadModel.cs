using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppBizbillBillfileDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppBizbillBillfileDownloadModel : AopObject
    {
        /// <summary>
        /// 账单日期，格式yyyy-MM-dd，仅支持T-1及之前的日期，最多支持近60天
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }
    }
}
