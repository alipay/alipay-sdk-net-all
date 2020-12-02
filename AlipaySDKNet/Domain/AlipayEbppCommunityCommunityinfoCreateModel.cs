using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityCommunityinfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityCommunityinfoCreateModel : AopObject
    {
        /// <summary>
        /// 别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 地市行政区化代码
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 小区编码，兼容迁移小区时所需；正常的非迁移的小区创建时不需要传
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 区县行政区化代码
        /// </summary>
        [XmlElement("county")]
        public string County { get; set; }

        /// <summary>
        /// 小区热线
        /// </summary>
        [XmlElement("hot_line")]
        public string HotLine { get; set; }

        /// <summary>
        /// 服务时间结束
        /// </summary>
        [XmlElement("hot_line_end")]
        public string HotLineEnd { get; set; }

        /// <summary>
        /// 服务时间开始
        /// </summary>
        [XmlElement("hot_line_start")]
        public string HotLineStart { get; set; }

        /// <summary>
        /// 小区名字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 地理信息
        /// </summary>
        [XmlArray("pois")]
        [XmlArrayItem("external_poi_info")]
        public List<ExternalPoiInfo> Pois { get; set; }

        /// <summary>
        /// 省行政区化代码
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 底座能力提供            SAAS 跳转模式支持            H5 ISV接口对接模式        REMOTE
        /// </summary>
        [XmlElement("support_type")]
        public string SupportType { get; set; }

        /// <summary>
        /// 业主姓名验证        NAME_VERIFY 业主手机验证        MOBILE_VERIFY 房间户号验证        ROOM_VERIFY(不传 则默认) 业主姓名+手机      NAME_MOBILE_VERIFY
        /// </summary>
        [XmlElement("verify_type")]
        public string VerifyType { get; set; }
    }
}
