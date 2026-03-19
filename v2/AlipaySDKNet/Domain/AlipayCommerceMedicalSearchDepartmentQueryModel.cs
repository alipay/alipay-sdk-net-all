using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalSearchDepartmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalSearchDepartmentQueryModel : AopObject
    {
        /// <summary>
        /// 渠道编码
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 缓存key类型
        /// </summary>
        [XmlElement("key_type")]
        public string KeyType { get; set; }

        /// <summary>
        /// 缓存key信息
        /// </summary>
        [XmlElement("page_key")]
        public string PageKey { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
