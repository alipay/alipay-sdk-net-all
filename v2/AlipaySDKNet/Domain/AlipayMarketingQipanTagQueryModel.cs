using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingQipanTagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingQipanTagQueryModel : AopObject
    {
        /// <summary>
        /// 圈选标签编码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
