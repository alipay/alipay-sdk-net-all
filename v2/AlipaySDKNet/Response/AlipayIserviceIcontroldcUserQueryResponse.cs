using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceIcontroldcUserQueryResponse.
    /// </summary>
    public class AlipayIserviceIcontroldcUserQueryResponse : AopResponse
    {
        /// <summary>
        /// 星云1088ID
        /// </summary>
        [XmlElement("nebula_id")]
        public string NebulaId { get; set; }

        /// <summary>
        /// 星云租户ID
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 小二1099ID
        /// </summary>
        [XmlElement("ur_id")]
        public string UrId { get; set; }
    }
}
