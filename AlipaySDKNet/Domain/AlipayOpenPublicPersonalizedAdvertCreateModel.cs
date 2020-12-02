using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicPersonalizedAdvertCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicPersonalizedAdvertCreateModel : AopObject
    {
        /// <summary>
        /// 广告位轮播内容列表，数量限制：大于1个，小于5个，广告位轮播内容顺序，根据接口传入的顺序排列
        /// </summary>
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 人群分组id
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，iphone、android、wp,不填为不区分机型
        /// </summary>
        [XmlElement("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
