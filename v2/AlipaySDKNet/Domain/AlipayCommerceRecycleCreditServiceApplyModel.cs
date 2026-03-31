using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleCreditServiceApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleCreditServiceApplyModel : AopObject
    {
        /// <summary>
        /// 商家绑定的支付宝登录账号
        /// </summary>
        [XmlElement("binding_alipay_logon_id")]
        public string BindingAlipayLogonId { get; set; }

        /// <summary>
        /// 信用取分段规则
        /// </summary>
        [XmlElement("rules")]
        public string Rules { get; set; }

        /// <summary>
        /// 公私域场景标识
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 服务类目编码
        /// </summary>
        [XmlElement("service_category")]
        public string ServiceCategory { get; set; }

        /// <summary>
        /// 二级商户的账户信息
        /// </summary>
        [XmlElement("submerchant")]
        public string Submerchant { get; set; }
    }
}
