using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageItempackageConsultResponse : AopResponse
    {
        /// <summary>
        /// 原始总价(分)
        /// </summary>
        [XmlElement("original_total_amount")]
        public string OriginalTotalAmount { get; set; }

        /// <summary>
        /// 原始单价(分)
        /// </summary>
        [XmlElement("original_unit_amount")]
        public string OriginalUnitAmount { get; set; }

        /// <summary>
        /// 折扣后总价(分)
        /// </summary>
        [XmlElement("trade_total_amount")]
        public string TradeTotalAmount { get; set; }
    }
}
