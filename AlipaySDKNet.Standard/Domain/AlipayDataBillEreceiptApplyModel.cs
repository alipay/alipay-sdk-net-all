using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataBillEreceiptApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataBillEreceiptApplyModel : AopObject
    {
        /// <summary>
        /// 根据不同业务类型，传入不同参数。格式如下：   * FUND_DETAIL - 资金业务回单。传入资金单号(fundOrderId，可通过充值、转账、提现接口获取)
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 申请的类型。可传入：     * FUND_DETAIL - 资金业务回单。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
