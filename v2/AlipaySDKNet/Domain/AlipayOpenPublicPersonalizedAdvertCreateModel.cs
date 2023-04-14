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
        /// 广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。
        /// </summary>
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// 人群分组id，修改为 <a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create">alipay.open.public.group.create</a>(用户分组创建接口)创建人群分组获取。
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 手机客户端类型，支持：iphone、android、wp。不填表示不区分机型。
        /// </summary>
        [XmlElement("mobile_client_type")]
        public string MobileClientType { get; set; }
    }
}
