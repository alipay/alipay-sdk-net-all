using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingThirdpartyRefundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingThirdpartyRefundQueryModel : AopObject
    {
        /// <summary>
        /// 退款异常订单的结束时间，可选，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 页码，从 1 开始
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 退款异常订单的开始时间，可选，格式 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
