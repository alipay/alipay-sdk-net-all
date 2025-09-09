using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateManagerDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateManagerDetailQueryModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 管理员ID
        /// </summary>
        [XmlElement("manager_id")]
        public string ManagerId { get; set; }
    }
}
