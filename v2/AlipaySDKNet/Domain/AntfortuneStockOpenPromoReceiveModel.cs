using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneStockOpenPromoReceiveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneStockOpenPromoReceiveModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 奖品发放参数
        /// </summary>
        [XmlArray("target_send_order_list")]
        [XmlArrayItem("target_send_order_param")]
        public List<TargetSendOrderParam> TargetSendOrderList { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
