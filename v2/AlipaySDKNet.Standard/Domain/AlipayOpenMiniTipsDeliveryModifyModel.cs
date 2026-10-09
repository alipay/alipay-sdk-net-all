using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTipsDeliveryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTipsDeliveryModifyModel : AopObject
    {
        /// <summary>
        /// 收藏引导投放活动ID
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 活动投放操作类型
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }
    }
}
