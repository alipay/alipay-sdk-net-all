using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechOceanbasePassportHuaweimpCreateResponse.
    /// </summary>
    public class AnttechOceanbasePassportHuaweimpCreateResponse : AopResponse
    {
        /// <summary>
        /// 通行证id，用户UID
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
