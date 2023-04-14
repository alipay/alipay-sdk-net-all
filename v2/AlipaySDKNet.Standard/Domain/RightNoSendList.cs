using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightNoSendList Data Structure.
    /// </summary>
    [Serializable]
    public class RightNoSendList : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 赠险标志
        /// </summary>
        [XmlElement("gift_prod_code")]
        public string GiftProdCode { get; set; }

        /// <summary>
        /// 赠险产品码
        /// </summary>
        [XmlElement("right_no")]
        public string RightNo { get; set; }

        /// <summary>
        /// 发放流水业务唯一编号
        /// </summary>
        [XmlElement("send_flow_no")]
        public string SendFlowNo { get; set; }

        /// <summary>
        /// 本次发放保额
        /// </summary>
        [XmlElement("send_sum_insured")]
        public string SendSumInsured { get; set; }

        /// <summary>
        /// 业务成功失败标记
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
