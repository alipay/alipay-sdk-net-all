using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedagentPicIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedagentPicIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片链接
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 敏感信息目标列表
        /// </summary>
        [XmlArray("target_list")]
        [XmlArrayItem("string")]
        public List<string> TargetList { get; set; }
    }
}
