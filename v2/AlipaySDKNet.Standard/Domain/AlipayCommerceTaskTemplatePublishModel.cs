using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTaskTemplatePublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTaskTemplatePublishModel : AopObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 任务模版id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
