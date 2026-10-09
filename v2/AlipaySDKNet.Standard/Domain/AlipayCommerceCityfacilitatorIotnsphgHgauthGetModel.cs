using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorIotnsphgHgauthGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCityfacilitatorIotnsphgHgauthGetModel : AopObject
    {
        /// <summary>
        /// 行业金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 设备ID
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 关联外部订单
        /// </summary>
        [XmlElement("ori_out_trade_no")]
        public string OriOutTradeNo { get; set; }

        /// <summary>
        /// 原请求ID
        /// </summary>
        [XmlElement("ori_req_id")]
        public string OriReqId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("req_id")]
        public string ReqId { get; set; }

        /// <summary>
        /// 业务标识处理id
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [XmlElement("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
