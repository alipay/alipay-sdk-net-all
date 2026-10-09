using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSearchBoxApplyResponse.
    /// </summary>
    public class AlipayOpenSearchBoxApplyResponse : AopResponse
    {
        /// <summary>
        /// 搜索直达配置id
        /// </summary>
        [XmlElement("box_id")]
        public string BoxId { get; set; }
    }
}
