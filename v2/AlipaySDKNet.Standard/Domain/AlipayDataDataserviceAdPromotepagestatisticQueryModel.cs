using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPromotepagestatisticQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPromotepagestatisticQueryModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 推广页id,获取推广页接口可以获取pageId
        /// </summary>
        [XmlElement("page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// 灯火商家ID
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 数据查询开始时间，查询时间间隔不能大于30天，点时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
