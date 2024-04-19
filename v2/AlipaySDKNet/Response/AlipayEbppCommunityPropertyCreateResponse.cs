using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppCommunityPropertyCreateResponse.
    /// </summary>
    public class AlipayEbppCommunityPropertyCreateResponse : AopResponse
    {
        /// <summary>
        /// 外部联系人
        /// </summary>
        [XmlElement("contacts")]
        public ExternalContact Contacts { get; set; }

        /// <summary>
        /// 物业公司名称拼音首字母大写+YYYYMMDD+防重位
        /// </summary>
        [XmlElement("property_short_name")]
        public string PropertyShortName { get; set; }
    }
}
