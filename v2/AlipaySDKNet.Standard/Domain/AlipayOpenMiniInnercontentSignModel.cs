using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnercontentSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnercontentSignModel : AopObject
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        [XmlArray("content_list")]
        [XmlArrayItem("sign_content_body_request")]
        public List<SignContentBodyRequest> ContentList { get; set; }

        /// <summary>
        /// 租户类型，由应用中心分配
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        [XmlElement("mini_app_id")]
        public string MiniAppId { get; set; }
    }
}
