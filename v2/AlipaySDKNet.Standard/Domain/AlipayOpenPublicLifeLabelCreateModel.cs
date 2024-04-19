using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeLabelCreateModel : AopObject
    {
        /// <summary>
        /// 标签值类型，不填默认为 string 类型。 注意：目前只支持 string（字符串类型）。
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 自定义标签名。 注意：每个生活号最多创建 100 个自定义标签。
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }
    }
}
