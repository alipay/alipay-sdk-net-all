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
        /// 工作台用户id
        /// </summary>
        [XmlElement("clv_user_id")]
        public string ClvUserId { get; set; }

        /// <summary>
        /// 权限码
        /// </summary>
        [XmlArray("codes")]
        [XmlArrayItem("string")]
        public List<string> Codes { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 人力资源id
        /// </summary>
        [XmlElement("ur_id")]
        public string UrId { get; set; }

        /// <summary>
        /// 鉴权uri
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// 星云用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
