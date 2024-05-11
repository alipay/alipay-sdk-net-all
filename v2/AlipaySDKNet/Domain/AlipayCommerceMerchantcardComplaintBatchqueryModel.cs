using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardComplaintBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardComplaintBatchqueryModel : AopObject
    {
        /// <summary>
        /// 投诉状态
        /// </summary>
        [XmlElement("complaint_status")]
        public string ComplaintStatus { get; set; }

        /// <summary>
        /// 投诉类型
        /// </summary>
        [XmlElement("complaint_type")]
        public string ComplaintType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
