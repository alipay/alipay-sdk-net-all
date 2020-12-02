using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPayAppChannelConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPayAppChannelConsultModel : AopObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 业务订单列表
        /// </summary>
        [XmlArray("biz_order_list")]
        [XmlArrayItem("biz_order_info")]
        public List<BizOrderInfo> BizOrderList { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 全局扩展参数
        /// </summary>
        [XmlElement("ext_params")]
        public BizExtInfo ExtParams { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
