using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeProfileSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantPayforprivilegeProfileSetModel : AopObject
    {
        /// <summary>
        /// 充享惠卡模板设置，用户使用充享惠业务领卡后会在支付宝卡包中使用该模板配置创建卡入口
        /// </summary>
        [XmlElement("card_template_config")]
        public PayForPrivilegeCardTemplateConfig CardTemplateConfig { get; set; }
    }
}
