using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldCaselaunchApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestShieldCaselaunchApplyModel : AopObject
    {
        /// <summary>
        /// 需要执行的测试用例id,多个id用逗号隔开
        /// </summary>
        [XmlElement("collection_ids")]
        public string CollectionIds { get; set; }

        /// <summary>
        /// 钉钉群的dingding_token，用来发送钉钉群消息
        /// </summary>
        [XmlElement("dingding_token")]
        public string DingdingToken { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_infos")]
        public string ExtInfos { get; set; }
    }
}
