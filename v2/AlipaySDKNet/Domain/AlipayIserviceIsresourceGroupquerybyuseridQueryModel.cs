using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIsresourceGroupquerybyuseridQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIsresourceGroupquerybyuseridQueryModel : AopObject
    {
        /// <summary>
        /// 租户id
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 星云用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
