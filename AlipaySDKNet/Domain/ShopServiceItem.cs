using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShopServiceItem Data Structure.
    /// </summary>
    [Serializable]
    public class ShopServiceItem : AopObject
    {
        /// <summary>
        /// 对服务的项目的详细描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务项目名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务项目需要图片素材
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("string")]
        public List<string> Pictures { get; set; }
    }
}
