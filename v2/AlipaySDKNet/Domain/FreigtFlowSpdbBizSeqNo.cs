using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreigtFlowSpdbBizSeqNo Data Structure.
    /// </summary>
    [Serializable]
    public class FreigtFlowSpdbBizSeqNo : AopObject
    {
        /// <summary>
        /// 渠道流水号，与交易流水号2选1填入即可
        /// </summary>
        [XmlElement("channel_seq_no")]
        public string ChannelSeqNo { get; set; }

        /// <summary>
        /// 交易流水号，与渠道流水号2选1填入即可
        /// </summary>
        [XmlElement("tran_seq_no")]
        public string TranSeqNo { get; set; }

        /// <summary>
        /// 核心交易流水号，目前为预留字段,暂不要使用
        /// </summary>
        [XmlElement("ylk_tran_seq_no")]
        public string YlkTranSeqNo { get; set; }
    }
}
