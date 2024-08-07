using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysistrafficPageeffectivelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysistrafficPageeffectivelistQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 查询单个页面的趋势数据 且需要传入trend==true
        /// </summary>
        [XmlElement("page_name")]
        public string PageName { get; set; }

        /// <summary>
        /// 搭配trend==true时 传入，且必须为MD5转化的值
        /// </summary>
        [XmlElement("page_url_md5")]
        public string PageUrlMd5 { get; set; }

        /// <summary>
        /// 此接口在列表数据中，需要查询单个页面或者单个url的趋势时候传入trend=true
        /// </summary>
        [XmlElement("trend")]
        public bool Trend { get; set; }
    }
}
