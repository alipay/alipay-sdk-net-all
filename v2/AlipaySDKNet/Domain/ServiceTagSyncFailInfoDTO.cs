using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceTagSyncFailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceTagSyncFailInfoDTO : AopObject
    {
        /// <summary>
        /// 标签同步的失败描述信息
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 服务标签元数据的编码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
