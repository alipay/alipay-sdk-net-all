using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FundPlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FundPlanDTO : AopObject
    {
        /// <summary>
        /// 合花群ID（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 转入金额（单位为元，必须大于0且最多小数点后两位）<br> - 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 转入周期类型，需要与date字段配合计算传入时间<br> - DAILY：每天<br> - WEEKLY：每周<br> - MONTHLY：每月<br> 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("calendar_type")]
        public string CalendarType { get; set; }

        /// <summary>
        /// （创建人）支付宝侧用户唯一标识<br> 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 转入周期值，需要与calendar_type字段配合计算传入时间<br> - 当calendar_type=DAILY时，该字段不填，表示每天（上午6点-下午3点间）会执行调拨任务进行资金转入操作<br> - 当calendar_type=WEEKLY时，该字段为必填（可选值为1-7），对应表示每周星期一或每周星期天（上午6点-下午3点间），会执行调拨任务进行资金转入操作<br> - 当calendar_type=MONTHLY时，该字段为必填（可选值为1-28），对应表示每月一号或每月28号（上午6点-下午3点间），会执行调拨任务进行资金转入操作<br> 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 当前合花群中的自动攒计划唯一标识（与当前请求参数中传入值保持一致）
        /// </summary>
        [XmlElement("fund_plan_id")]
        public string FundPlanId { get; set; }

        /// <summary>
        /// 当前计划预计下次开始执行时间（ yyyy-MM-dd HH:mm:ss.SSS）<br> 补充说明：虽然该字段精确到时分秒，但由于调拨计划数较多，会出现排队现象，具体执行时间无法保证，尽量当天上午6点-下午3点间执行完成
        /// </summary>
        [XmlElement("next_execution")]
        public string NextExecution { get; set; }

        /// <summary>
        /// 转入时付款方所指定的资产信息
        /// </summary>
        [XmlElement("payer_account")]
        public PayerAccountDTO PayerAccount { get; set; }

        /// <summary>
        /// 订单备注<br> 补充说明：该字段与alipay.fund.jointaccount.fundplan.create请求参数中传入值保持一致
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 计划状态<br> - VALIDATE：正常生效中<br> - PAUSE 暂停中<br> - CLOSED 已删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
