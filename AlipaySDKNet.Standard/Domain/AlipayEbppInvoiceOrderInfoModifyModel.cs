using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceOrderInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceOrderInfoModifyModel : AopObject
    {
        /// <summary>
        /// 实际结算金额
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 入住时间格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_check_in")]
        public string GmtCheckIn { get; set; }

        /// <summary>
        /// 离店时间(入住日期非空时，离店时间非空) 格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("gmt_check_out")]
        public string GmtCheckOut { get; set; }

        /// <summary>
        /// 订单开票状态（0, "未开票"  4, "开票中"  8, "开票成功"  16 取消开票  32, "预约开票"  64, "开票失败"  ）
        /// </summary>
        [XmlElement("inv_status")]
        public long InvStatus { get; set; }

        /// <summary>
        /// 订单号（platform_code+order_id唯一）
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态（1-入住中，2-离店已结算）
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 业务平台code, 由发票中台分配
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 业务平台商户ID/用户ID
        /// </summary>
        [XmlElement("platform_user_id")]
        public string PlatformUserId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
