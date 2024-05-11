using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarOrdermodifyApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarOrdermodifyApplyModel : AopObject
    {
        /// <summary>
        /// 修改后租期的结束时间。目前仅支持续租。例如原始订单租期是1号~2号，续租1天，修改后租期就是1号~3号，结束时间修改为3号
        /// </summary>
        [XmlElement("modified_end_time")]
        public string ModifiedEndTime { get; set; }

        /// <summary>
        /// 修改后租期的开始时间。目前仅支持续租。例如原始订单租期是1号~2号，续租1天，修改后租期就是1号~3号，开始时间仍然是1号
        /// </summary>
        [XmlElement("modified_start_time")]
        public string ModifiedStartTime { get; set; }

        /// <summary>
        /// 支付宝用户开放id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 发起修改订单的租车单的商户侧订单号
        /// </summary>
        [XmlElement("parent_out_order_no")]
        public string ParentOutOrderNo { get; set; }

        /// <summary>
        /// 修改订单后需要用户支付的费用总金额，单位分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝用户的userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
