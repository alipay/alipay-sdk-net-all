using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryCareertrainingPaymentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryCareertrainingPaymentBatchqueryModel : AopObject
    {
        /// <summary>
        /// bizType=COURSE，课程id bizType=EXAM，评价id
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// COURSE-课程、EXAM-评价
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
