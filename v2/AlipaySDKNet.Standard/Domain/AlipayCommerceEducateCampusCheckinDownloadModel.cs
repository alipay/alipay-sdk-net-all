using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCampusCheckinDownloadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCampusCheckinDownloadModel : AopObject
    {
        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
