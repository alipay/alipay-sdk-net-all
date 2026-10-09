using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoContentApiSchemaVO Data Structure.
    /// </summary>
    [Serializable]
    public class PromoContentApiSchemaVO : AopObject
    {
        /// <summary>
        /// 内容的配置示意图
        /// </summary>
        [XmlElement("demo_pic")]
        public string DemoPic { get; set; }

        /// <summary>
        /// 内容的元数据ID
        /// </summary>
        [XmlElement("schema_id")]
        public string SchemaId { get; set; }

        /// <summary>
        /// xml格式的schema；这里规定了场景素材需要的字段，字段的类型以及字段的规则要求。 场景素材中的图片字段，要求上传的是这个图片在文件存储平台的标识即图片文件ID（详见接口alipay.open.app.service.image.upload）
        /// </summary>
        [XmlElement("schema_xml")]
        public string SchemaXml { get; set; }
    }
}
