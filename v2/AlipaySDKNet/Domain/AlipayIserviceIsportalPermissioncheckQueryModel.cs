using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsportalPermissioncheckQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsportalPermissioncheckQueryModel : AopObject
    {
        /// <summary>
        /// 星云对应的buservice的ID
        /// </summary>
        [XmlElement("busvc_cloud_id")]
        public string BusvcCloudId { get; set; }

        /// <summary>
        /// 蚂蚁权限id
        /// </summary>
        [XmlElement("busvc_id")]
        public string BusvcId { get; set; }

        /// <summary>
        /// 权限码
        /// </summary>
        [XmlArray("codes")]
        [XmlArrayItem("string")]
        public List<string> Codes { get; set; }

        /// <summary>
        /// 鉴权uri
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
