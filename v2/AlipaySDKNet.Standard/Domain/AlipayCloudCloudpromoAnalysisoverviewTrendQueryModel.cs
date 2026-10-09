using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewTrendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysisoverviewTrendQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 经营概况模块，多端分析中支付宝端的小程序app_id
        /// </summary>
        [XmlElement("hit_app_id")]
        public string HitAppId { get; set; }

        /// <summary>
        /// 小程序模板，指创建商家小程序的模版，传入后根据该小程序模版对分析数据过滤
        /// </summary>
        [XmlElement("template")]
        public string Template { get; set; }
    }
}
