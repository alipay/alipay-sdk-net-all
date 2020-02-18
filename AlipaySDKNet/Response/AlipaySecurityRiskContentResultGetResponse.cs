using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskContentResultGetResponse.
    /// </summary>
    public class AlipaySecurityRiskContentResultGetResponse : AopResponse
    {
        /// <summary>
        /// 命中结果详情
        /// </summary>
        [XmlArray("hit_detect_items")]
        [XmlArrayItem("info_sec_hit_detect_item")]
        public List<InfoSecHitDetectItem> HitDetectItems { get; set; }

        /// <summary>
        /// PASSED("数据识别通过，可以在网站上正常显示")    REJECTED("被拒绝的数据，比如内容出现违禁词；不能出现在我们网站上")
        /// </summary>
        [XmlElement("result_action")]
        public string ResultAction { get; set; }
    }
}
