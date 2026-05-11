using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TagSnInfoListRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TagSnInfoListRequest : AopObject
    {
        /// <summary>
        /// 线圈生成的id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 厂商线圈sn信息
        /// </summary>
        [XmlElement("tag_sn")]
        public string TagSn { get; set; }
    }
}
