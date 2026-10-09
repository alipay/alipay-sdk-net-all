using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdOnlineResponse.
    /// </summary>
    public class AlipayDataDataserviceAdOnlineResponse : AopResponse
    {
        /// <summary>
        /// 操作成功外部ID列表
        /// </summary>
        [XmlArray("success_id_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessIdList { get; set; }
    }
}
