using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyOrderCreateResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 申请单ID，后续接口需要依赖该单号
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请单使用的物料模版对应的物料类型
        /// </summary>
        [XmlElement("materials_template_type")]
        public string MaterialsTemplateType { get; set; }
    }
}
