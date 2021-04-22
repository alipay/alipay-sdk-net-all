using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileSetResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeProfileSetResponse : AopResponse
    {
        /// <summary>
        /// 卡包充值卡面模板设置
        /// </summary>
        [XmlElement("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
