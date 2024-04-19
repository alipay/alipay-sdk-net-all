using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CompanyBaseVO Data Structure.
    /// </summary>
    [Serializable]
    public class CompanyBaseVO : AopObject
    {
        /// <summary>
        /// 公司id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// OU代码
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }
    }
}
