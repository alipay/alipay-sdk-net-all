using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNordermaterialsapplyMaterialsCreateResponse.
    /// </summary>
    public class AlipayOpenSpNordermaterialsapplyMaterialsCreateResponse : AopResponse
    {
        /// <summary>
        /// 成立成功的二维码链接，与入参对应
        /// </summary>
        [XmlArray("qr_code_url_list")]
        [XmlArrayItem("string")]
        public List<string> QrCodeUrlList { get; set; }
    }
}
