using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudFinsaasCrowdDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudFinsaasCrowdDeleteModel : AopObject
    {
        /// <summary>
        /// 人群ID+唯一+删除人群
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }
    }
}
