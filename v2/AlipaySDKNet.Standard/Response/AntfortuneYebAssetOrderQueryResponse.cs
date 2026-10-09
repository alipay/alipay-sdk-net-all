using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneYebAssetOrderQueryResponse.
    /// </summary>
    public class AntfortuneYebAssetOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单关闭方
        /// </summary>
        [XmlElement("close_by")]
        public string CloseBy { get; set; }

        /// <summary>
        /// 订单关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 订单关闭时间
        /// </summary>
        [XmlElement("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单超时时间
        /// </summary>
        [XmlElement("order_timeout")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
