using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceTenantquerybyuridQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceTenantquerybyuridQueryModel : AopObject
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
