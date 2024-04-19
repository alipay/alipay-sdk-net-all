using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseEntityroleHuaweimpQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseEntityroleHuaweimpQueryModel : AopObject
    {
        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
