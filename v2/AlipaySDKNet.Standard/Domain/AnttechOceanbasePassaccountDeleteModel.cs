using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountDeleteModel : AopObject
    {
        /// <summary>
        /// OceanBase Cloud的用户Id，可从个人中心获取
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
