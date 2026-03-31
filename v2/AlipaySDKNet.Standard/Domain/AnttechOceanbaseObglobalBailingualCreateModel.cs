using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalBailingualCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalBailingualCreateModel : AopObject
    {
        /// <summary>
        /// 动态在百灵平台创建及发布文案,支持批量操作
        /// </summary>
        [XmlElement("create_text_request")]
        public CreateTextRequest CreateTextRequest { get; set; }
    }
}
