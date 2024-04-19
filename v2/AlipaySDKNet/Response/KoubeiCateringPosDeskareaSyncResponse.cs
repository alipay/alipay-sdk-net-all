using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringPosDeskareaSyncResponse.
    /// </summary>
    public class KoubeiCateringPosDeskareaSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回主键
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }
    }
}
