using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateModifyResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateModifyResponse : AopResponse
    {
        /// <summary>
        /// 修改后模版的过期时间
        /// </summary>
        [XmlElement("publish_end_time")]
        public string PublishEndTime { get; set; }
    }
}
