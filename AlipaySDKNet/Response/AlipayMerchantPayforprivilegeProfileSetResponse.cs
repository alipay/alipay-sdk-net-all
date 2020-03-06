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
        /// 充享惠卡模板设置
        /// </summary>
        [XmlElement("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
