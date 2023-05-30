using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceOrganizationqueryallQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceOrganizationqueryallQueryModel : AopObject
    {
        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
