using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicAdvertModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicAdvertModifyModel : AopObject
    {
        /// <summary>
        /// 广告位id，通过<a href="https://opendocs.alipay.com/apis/api_6/alipay.open.public.advert.create">alipay.open.public.advert.create</a>(生活号广告位添加接口)添加广告位获取。
        /// </summary>
        [XmlElement("advert_id")]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。
        /// </summary>
        [XmlArray("advert_items")]
        [XmlArrayItem("advert_item")]
        public List<AdvertItem> AdvertItems { get; set; }
    }
}
