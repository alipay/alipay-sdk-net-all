using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionSpecialadvcontentModifyResponse.
    /// </summary>
    public class KoubeiAdvertCommissionSpecialadvcontentModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改特殊广告内容的返回结果
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("kb_advert_special_adv_content_modify_response")]
        public List<KbAdvertSpecialAdvContentModifyResponse> Data { get; set; }
    }
}
