using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPrincipaldmpSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPrincipaldmpSyncModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 商户人群id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 商户人群名称
        /// </summary>
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 商户在灯火平台的唯一标签，请联系商户获取
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 人群关联策略：${bizdate}-n : ${bizdate}为固定值，代表当天，n为天数。如果当天为28号，n=1，则表示拉取27号的数；${recent}: ${recent}为固定值，调度时拉取最近一次更新的数据
        /// </summary>
        [XmlElement("strategy")]
        public string Strategy { get; set; }
    }
}
