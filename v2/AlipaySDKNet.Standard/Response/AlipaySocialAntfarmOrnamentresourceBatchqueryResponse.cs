using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialAntfarmOrnamentresourceBatchqueryResponse.
    /// </summary>
    public class AlipaySocialAntfarmOrnamentresourceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 蚂蚁庄园装扮资源
        /// </summary>
        [XmlArray("ornament_resource_list")]
        [XmlArrayItem("antfarm_ornament_resource")]
        public List<AntfarmOrnamentResource> OrnamentResourceList { get; set; }

        /// <summary>
        /// spine资源地址
        /// </summary>
        [XmlElement("spine_resource_url")]
        public string SpineResourceUrl { get; set; }
    }
}
