using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceTenantquerybytntidQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceTenantquerybytntidQueryModel : AopObject
    {
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
    }
}
