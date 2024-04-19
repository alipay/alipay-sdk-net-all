using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeexchangeUseResponse.
    /// </summary>
    public class AntfortuneEquityInstpointPrizeexchangeUseResponse : AopResponse
    {
        /// <summary>
        /// 积分兑换奖品结果。  INIT:  申请中，可能成功，可能失败。需要使用相同的out_biz_no重试判定结果，一般2分钟内会判定处理结果  FAIL:  兑换失败  SUCCESS：兑换成功
        /// </summary>
        [XmlElement("exchange_result")]
        public string ExchangeResult { get; set; }

        /// <summary>
        /// 积分兑换奖品流水。幂等返回结果时，流水号相同
        /// </summary>
        [XmlElement("exchange_trans_no")]
        public string ExchangeTransNo { get; set; }
    }
}
