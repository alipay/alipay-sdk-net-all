using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandIndirectBindQueryResponse.
    /// </summary>
    public class AntMerchantExpandIndirectBindQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户ID 若传入smid返回。为空表示没有
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// smid列表 若传入partner_id返回。为空表示没有
        /// </summary>
        [XmlArray("smid")]
        [XmlArrayItem("string")]
        public List<string> Smid { get; set; }
    }
}
