using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepageDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPromotepageDownloadModel : AopObject
    {
        /// <summary>
        /// 代理商访问灯火平台的token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 留资结束日期，格式：yyyy-mm-dd；不能晚于当天
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 分页参数之页数，从1开始
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小，最大1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家标志
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 推广页id
        /// </summary>
        [XmlElement("promote_page_id")]
        public long PromotePageId { get; set; }

        /// <summary>
        /// 留资开始日期，格式：yyyy-mm-dd，不能早于30天前
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
