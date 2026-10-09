using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantZmgoTemplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantZmgoTemplateQueryModel : AopObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 模板ID，由创建模板接口返回结果提供
        /// </summary>
        [XmlElement("template_no")]
        public string TemplateNo { get; set; }
    }
}
