using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthYepModelConsultResponse.
    /// </summary>
    public class AlipayFinancialnetAuthYepModelConsultResponse : AopResponse
    {
        /// <summary>
        /// 业务模式
        /// </summary>
        [XmlElement("biz_model")]
        public string BizModel { get; set; }

        /// <summary>
        /// 当biz_model返回 直接签约或可引导签约，可跳转到链接，签约余额升级
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
