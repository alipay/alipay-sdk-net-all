using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalTagCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalTagCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 标签操作请求体
        /// </summary>
        [XmlElement("operate_tag_request")]
        public TagOperationRequest OperateTagRequest { get; set; }
    }
}
