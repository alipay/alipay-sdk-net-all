using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DistributionOrderInspectProofDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DistributionOrderInspectProofDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("img_ids")]
        [XmlArrayItem("string")]
        public List<string> ImgIds { get; set; }

        /// <summary>
        /// 异常描述
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
