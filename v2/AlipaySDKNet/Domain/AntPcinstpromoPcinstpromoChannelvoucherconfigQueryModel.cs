using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntPcinstpromoPcinstpromoChannelvoucherconfigQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntPcinstpromoPcinstpromoChannelvoucherconfigQueryModel : AopObject
    {
        /// <summary>
        /// P站配置的活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }
    }
}
