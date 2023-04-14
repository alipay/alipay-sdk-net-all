using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoSyncResponse.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回kaCode唯一标识,用户查询ka信息时候用
        /// </summary>
        [XmlElement("ka_code")]
        public string KaCode { get; set; }
    }
}
