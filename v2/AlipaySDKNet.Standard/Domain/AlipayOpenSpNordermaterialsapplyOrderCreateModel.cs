using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSpNordermaterialsapplyOrderCreateModel : AopObject
    {
        /// <summary>
        /// 与支付宝约定模版样式后，提供模版编号，接口传入
        /// </summary>
        [XmlElement("materials_template_code")]
        public string MaterialsTemplateCode { get; set; }
    }
}
