using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PayChannelPromoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PayChannelPromoInfo : AopObject
    {
        /// <summary>
        /// 渠道额度
        /// </summary>
        [XmlElement("channel_balance")]
        public string ChannelBalance { get; set; }

        /// <summary>
        /// 前置咨询渠道的渠道编码，从支付决策获取，可对外输出
        /// </summary>
        [XmlElement("channel_code")]
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道扩展信息
        /// </summary>
        [XmlElement("channel_detail_params")]
        public ChannelDetailParams ChannelDetailParams { get; set; }

        /// <summary>
        /// 渠道可用性标识
        /// </summary>
        [XmlElement("channel_enable")]
        public bool ChannelEnable { get; set; }

        /// <summary>
        /// 渠道唯一索引
        /// </summary>
        [XmlElement("channel_index")]
        public string ChannelIndex { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [XmlElement("channel_name")]
        public string ChannelName { get; set; }

        /// <summary>
        /// 支付时需要带回的渠道信息
        /// </summary>
        [XmlElement("channel_operation_info")]
        public string ChannelOperationInfo { get; set; }

        /// <summary>
        /// 分期模型
        /// </summary>
        [XmlElement("installment_info_list")]
        public InstallmentInfo InstallmentInfoList { get; set; }

        /// <summary>
        /// 营销模型
        /// </summary>
        [XmlElement("operation_list")]
        public PrePayOperationInfo OperationList { get; set; }
    }
}
