using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSchemaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppServiceSchemaQueryModel : AopObject
    {
        /// <summary>
        /// 类目id, 获取请参考<a href="https://opendocs.alipay.com/mini/03ci0w?pathHash=ed3c875c">各个行业场景服务接入资料</a>
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 服务模版类型，默认值:DEFAULT
        /// </summary>
        [XmlElement("template_type")]
        public string TemplateType { get; set; }
    }
}
