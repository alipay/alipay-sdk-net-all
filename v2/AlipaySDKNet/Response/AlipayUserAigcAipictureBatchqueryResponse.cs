using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserAigcAipictureBatchqueryResponse.
    /// </summary>
    public class AlipayUserAigcAipictureBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// AIGC生成的多媒体图片列表
        /// </summary>
        [XmlArray("pic_list")]
        [XmlArrayItem("ai_picture")]
        public List<AiPicture> PicList { get; set; }
    }
}
