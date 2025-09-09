using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceMediaReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceMediaReportQueryModel : AopObject
    {
        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("ad_pos_id")]
        public string AdPosId { get; set; }

        /// <summary>
        /// 应用id，需要查询的灯火应用id，非必填参数
        /// </summary>
        [XmlElement("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 数据查询结束日期，时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商家pid，非必填参数；type=AGENCY的情况必须传入
        /// </summary>
        [XmlElement("m_pid")]
        public string MPid { get; set; }

        /// <summary>
        /// 当前页码，默认1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，默认值10，最大1000
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 展位码
        /// </summary>
        [XmlElement("space_code")]
        public string SpaceCode { get; set; }

        /// <summary>
        /// 数据查询开始日期，时间格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// MERCHANT：商家；AGENCY：服务商
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
