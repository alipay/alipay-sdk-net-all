using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayAssetVoucherTemplateInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetVoucherTemplateInfoQueryModel : AopObject
    {
        /// <summary>
        /// 券模版id，传入券模板id后，返回对应的券模版详细信息
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
