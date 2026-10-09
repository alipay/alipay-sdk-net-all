using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoAnalysisoverviewApplistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoAnalysisoverviewApplistQueryModel : AopObject
    {
        /// <summary>
        /// 经营分析、经营概况模块公用入参
        /// </summary>
        [XmlElement("common_request")]
        public OpenApiAnalysisCommonRequest CommonRequest { get; set; }

        /// <summary>
        /// 经营概况模块, 多端分析中支付宝端的小程序app_id
        /// </summary>
        [XmlElement("hit_app_id")]
        public string HitAppId { get; set; }

        /// <summary>
        /// 服务商实际下，会有多个商户及其小程序app列表，可以选择传入商户ID进行过滤查看某一个商户及其小程序app列表
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
