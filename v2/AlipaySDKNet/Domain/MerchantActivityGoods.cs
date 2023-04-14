using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantActivityGoods Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantActivityGoods : AopObject
    {
        /// <summary>
        /// 活动单品信息
        /// </summary>
        [XmlArray("activity_goods_benefit")]
        [XmlArrayItem("activity_goods")]
        public List<ActivityGoods> ActivityGoodsBenefit { get; set; }

        /// <summary>
        /// 商家活动状态 INIT("INIT","初始化"), ENROLLING("ENROLLING", "报名中"), GOING("GOING", "进行中"), STOP("STOP", "中止")
        /// </summary>
        [XmlElement("merchant_activity_status")]
        public string MerchantActivityStatus { get; set; }

        /// <summary>
        /// 商户pid，唯一标识
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
