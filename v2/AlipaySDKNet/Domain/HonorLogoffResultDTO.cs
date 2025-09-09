using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorLogoffResultDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorLogoffResultDTO : AopObject
    {
        /// <summary>
        /// 荣耀侧授信申请流水号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 渠道用户id
        /// </summary>
        [XmlElement("channel_customer_id")]
        public string ChannelCustomerId { get; set; }

        /// <summary>
        /// 注销失败描述
        /// </summary>
        [XmlElement("logoff_err_desc")]
        public string LogoffErrDesc { get; set; }

        /// <summary>
        /// 1-注销成功--处理完成的结果 0-注销失败（不允许出现）
        /// </summary>
        [XmlElement("logoff_status")]
        public long LogoffStatus { get; set; }

        /// <summary>
        /// 渠道方授信流水号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
