using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsportalLogindigestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsportalLogindigestQueryModel : AopObject
    {
        /// <summary>
        /// 星云对应的用户平台的ID
        /// </summary>
        [XmlElement("ur_id")]
        public string UrId { get; set; }
    }
}
