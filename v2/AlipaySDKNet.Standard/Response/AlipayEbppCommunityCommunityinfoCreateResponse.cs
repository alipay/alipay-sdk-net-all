using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityCommunityinfoCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityCommunityinfoCreateResponse : AopResponse
    {
        /// <summary>
        /// 小区名字拼音首字母大写+YYYYMMDD+防重位
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// 支付宝app中的该小区跳转地址
        /// </summary>
        [XmlElement("community_url")]
        public string CommunityUrl { get; set; }
    }
}
