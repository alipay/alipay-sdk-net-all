using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportChargerSiteselectionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportChargerSiteselectionCreateModel : AopObject
    {
        /// <summary>
        /// 数据计算任务条件
        /// </summary>
        [XmlElement("site_selection_param")]
        public SiteSelectionParam SiteSelectionParam { get; set; }

        /// <summary>
        /// 数据计算任务模板编码，请按需求传入指定枚举类型传值
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }
    }
}
