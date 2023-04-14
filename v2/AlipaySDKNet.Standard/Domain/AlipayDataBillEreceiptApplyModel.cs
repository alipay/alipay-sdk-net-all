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
        /// 授权商户pid。需调用方获取商户授权，才可使用。
        /// </summary>
        [XmlElement("bill_user_id")]
        public string BillUserId { get; set; }

        /// <summary>
        /// 根据不同业务类型，传入不同参数。 格式如下： * ACCOUNT_LOG_DETAIL - 传入账务流水号，示例：117007*********9151 * ACCOUNT_FLOW_DETAIL - 传入流水日期区间示例：20220301-20220331 * FUND_DETAIL - 传入资金单据号，示例：2022051511007***************0731 * ACCOUNT_LOG_SUM_DAILY - 传入日期，示例：2022-01-01 * ACCOUNT_LOG_SUM_MONTHLY - 传入月份，示例：2022-01
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 申请的类型。可传入： * ACCOUNT_LOG_DETAIL - 余额收支证明 * ACCOUNT_FLOW_DETAIL - 余额收支流水证明 * FUND_DETAIL - 转入转出收支证明 * ACCOUNT_LOG_SUM_DAILY - 收支汇总证明（日汇总） * ACCOUNT_LOG_SUM_MONTHLY - 收支汇总证明（月汇总）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
