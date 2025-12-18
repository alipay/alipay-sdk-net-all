using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcActivityGrayModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcActivityGrayModifyModel : AopObject
    {
        /// <summary>
        /// 员工价活动id，用于指定需要修改灰度策略的活动；通过 alipay.commerce.ec.activity.discount.create 创建活动
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 蚂蚁门店id，用于水平权限鉴权；通过 ant.merchant.expand.shop.create 创建蚂蚁门店
        /// </summary>
        [XmlElement("ant_shop_id")]
        public string AntShopId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("gray_account_list")]
        [XmlArrayItem("string")]
        public List<string> GrayAccountList { get; set; }
    }
}
