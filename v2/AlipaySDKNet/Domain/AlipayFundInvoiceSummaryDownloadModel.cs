using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundInvoiceSummaryDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundInvoiceSummaryDownloadModel : AopObject
    {
        /// <summary>
        /// 校验日期，yyyymmdd
        /// </summary>
        [XmlElement("check_date")]
        public string CheckDate { get; set; }
    }
}
