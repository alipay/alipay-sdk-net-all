using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HonorRepayRecordDTO Data Structure.
    /// </summary>
    [Serializable]
    public class HonorRepayRecordDTO : AopObject
    {
        /// <summary>
        /// 蚂蚁侧借款订单单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 还款交易流水号
        /// </summary>
        [XmlElement("out_repay_no")]
        public string OutRepayNo { get; set; }

        /// <summary>
        /// 还款金额，单位：分。还款中、还款失败时返回申请金额，还款成功时返回实际还款金额
        /// </summary>
        [XmlElement("repay_amount")]
        public string RepayAmount { get; set; }

        /// <summary>
        /// 还款失败原因
        /// </summary>
        [XmlElement("repay_result")]
        public string RepayResult { get; set; }

        /// <summary>
        /// 还款状态，1-还款中，2-还款成功，4-还款失败（还款中只会返回收银后的）
        /// </summary>
        [XmlElement("repay_status")]
        public long RepayStatus { get; set; }

        /// <summary>
        /// 实际还款时间，毫秒(还款中为还款申请提交的时间，还款失败和成功为实际还款时间)
        /// </summary>
        [XmlElement("repay_time")]
        public long RepayTime { get; set; }
    }
}
