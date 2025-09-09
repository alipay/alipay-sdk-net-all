using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandLeadsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandLeadsQueryModel : AopObject
    {
        /// <summary>
        /// leads信息查询主键
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
