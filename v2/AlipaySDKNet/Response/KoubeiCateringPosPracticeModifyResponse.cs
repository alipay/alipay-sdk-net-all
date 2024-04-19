using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosPracticeModifyResponse.
    /// </summary>
    public class KoubeiCateringPosPracticeModifyResponse : AopResponse
    {
        /// <summary>
        /// 做法id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
