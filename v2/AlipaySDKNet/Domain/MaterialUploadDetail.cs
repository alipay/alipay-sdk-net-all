using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MaterialUploadDetail Data Structure.
    /// </summary>
    [Serializable]
    public class MaterialUploadDetail : AopObject
    {
        /// <summary>
        /// 广告投放平台生成的物料实例ID
        /// </summary>
        [XmlElement("material_instance_id")]
        public long MaterialInstanceId { get; set; }

        /// <summary>
        /// SUCCESS-成功 FAILED-失败 PROCESSING-处理中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
