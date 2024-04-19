using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Advert Data Structure.
    /// </summary>
    [Serializable]
    public class Advert : AopObject
    {
        /// <summary>
        /// 广告组标识
        /// </summary>
        [XmlElement("advert_group")]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表
        /// </summary>
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 投放人群分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,空为不区分机型
        /// </summary>
        [XmlElement("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
