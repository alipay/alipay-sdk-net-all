using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCrowdConsultResponse.
    /// </summary>
    public class AlipayTradeCrowdConsultResponse : AopResponse
    {
        /// <summary>
        /// 淘宝的活动id列表
        /// </summary>
        [XmlArray("activity_code_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityCodeList { get; set; }

        /// <summary>
        /// Y表示是营销人群 N表示不是营销人群
        /// </summary>
        [XmlElement("promoted_user")]
        public string PromotedUser { get; set; }

        /// <summary>
        /// 场景对应的执行结果
        /// </summary>
        [XmlElement("scene_result")]
        public SceneResult SceneResult { get; set; }
    }
}
