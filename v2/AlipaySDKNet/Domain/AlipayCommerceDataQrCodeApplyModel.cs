using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceDataQrCodeApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceDataQrCodeApplyModel : AopObject
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展信息，未指定的key支付宝侧不消费
        /// </summary>
        [XmlArray("ext_info")]
        [XmlArrayItem("scenic_ext_info")]
        public List<ScenicExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 服务商pid，用于发码埋参
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 业务幂等号，同一家服务商outerBizId+shopId+bizType相同，会发放相同的二维码
        /// </summary>
        [XmlElement("outer_biz_id")]
        public string OuterBizId { get; set; }

        /// <summary>
        /// 指定页面URL，需保证URL符合小程序的schemes固定格式。 schemes固定格式：alipays://platformapi/startapp?appId=【appid】&page=【具体页面】；appid是对应小程序的appid，格式检测到“&page=”，page后的具体页面链接不做限制。  URL的page内容由服务商自定义，需要识别门店的建议服务商在url带入shopid的识别，建议格式： alipays://platformapi/startapp?appId=【appid】&page=【具体页面】&query=【shopid等传参】
        /// </summary>
        [XmlElement("page_url")]
        public string PageUrl { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 接入服务商的标识，接入前请提前联系支付宝技术人员分配
        /// </summary>
        [XmlElement("source_code")]
        public string SourceCode { get; set; }
    }
}
