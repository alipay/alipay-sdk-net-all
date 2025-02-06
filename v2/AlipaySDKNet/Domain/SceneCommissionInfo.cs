using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SceneCommissionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SceneCommissionInfo : AopObject
    {
        /// <summary>
        /// 抽佣结束时间
        /// </summary>
        [XmlElement("commission_invalid_time")]
        public string CommissionInvalidTime { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("commission_list")]
        [XmlArrayItem("commission_info")]
        public List<CommissionInfo> CommissionList { get; set; }

        /// <summary>
        /// 抽佣模式，统一模式或商品模式
        /// </summary>
        [XmlElement("commission_mode")]
        public string CommissionMode { get; set; }

        /// <summary>
        /// 抽佣场景，周期卡代开发
        /// </summary>
        [XmlElement("commission_scene")]
        public string CommissionScene { get; set; }

        /// <summary>
        /// 抽佣开始时间
        /// </summary>
        [XmlElement("commission_valid_time")]
        public string CommissionValidTime { get; set; }

        /// <summary>
        /// 代表长期模式场景模式不用传抽佣时间
        /// </summary>
        [XmlElement("long_term")]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 商家应用appId，代开发场景需要
        /// </summary>
        [XmlElement("merchant_app_id")]
        public string MerchantAppId { get; set; }
    }
}
