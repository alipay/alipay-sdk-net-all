using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlawOrderhitstatusQueryResponse.
    /// </summary>
    public class AlipayBossProdAntlawOrderhitstatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否存在有效的纸质用印, true表示存在, false表示不存在
        /// </summary>
        [XmlElement("hit_result")]
        public bool HitResult { get; set; }
    }
}
