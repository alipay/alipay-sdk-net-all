using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubAccountBalanceFreezeOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubAccountBalanceFreezeOrder : AopObject
    {
        /// <summary>
        /// 需要冻结金额，如果可用余额大于冻结金额则冻结
        /// </summary>
        [XmlElement("freeze_amount")]
        public MultiCurrencyMoney FreezeAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 上游申请请求单号，source + outBizNo 用于幂等。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 来源，通常为业务系统名，source + outBizNo 用于幂等。
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 子户基本信息，用于子户识别
        /// </summary>
        [XmlElement("sub_account_base_info")]
        public SubAccountBaseInfo SubAccountBaseInfo { get; set; }
    }
}
