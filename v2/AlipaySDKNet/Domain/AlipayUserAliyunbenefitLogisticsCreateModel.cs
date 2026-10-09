using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAliyunbenefitLogisticsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAliyunbenefitLogisticsCreateModel : AopObject
    {
        /// <summary>
        /// 物流公司编码
        /// </summary>
        [XmlElement("company_code")]
        public string CompanyCode { get; set; }

        /// <summary>
        /// linkedmall 订单号
        /// </summary>
        [XmlElement("lm_order_id")]
        public long LmOrderId { get; set; }

        /// <summary>
        /// 物流状态，2 = 已发货 -> 等待买家确认收货 3 = 已收货 -> 交易成功
        /// </summary>
        [XmlElement("logistics_status")]
        public long LogisticsStatus { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [XmlElement("mail_no")]
        public string MailNo { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单状态枚举
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
