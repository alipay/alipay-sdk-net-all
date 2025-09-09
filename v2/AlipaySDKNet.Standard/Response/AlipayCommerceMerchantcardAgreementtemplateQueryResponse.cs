using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMerchantcardAgreementtemplateQueryResponse.
    /// </summary>
    public class AlipayCommerceMerchantcardAgreementtemplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 购卡需要签署的协议模板，需要注意的是这个返回值使用html标签来处理格式，展示的时候需要按照html来解析展示
        /// </summary>
        [XmlElement("order_agreement_template_content")]
        public string OrderAgreementTemplateContent { get; set; }
    }
}
