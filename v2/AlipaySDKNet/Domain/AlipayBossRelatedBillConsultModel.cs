using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossRelatedBillConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossRelatedBillConsultModel : AopObject
    {
        /// <summary>
        /// 业务发生时间,格式为 2022-02-02
        /// </summary>
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 拓展信息:业务流水ID、产品码等，可不传。目前影响识别结果的Key有：salesProductCode、POINT_EXCHANGE_GOODS、relTradeSettleType、feeItemCode、oppositeAssetTypeCode、gfaIdentityId
        /// </summary>
        [XmlElement("extra_infos")]
        public string ExtraInfos { get; set; }

        /// <summary>
        /// 咨询的关联方公司生效时间是否按照整月生效。
        /// </summary>
        [XmlElement("is_whole_month_valid")]
        public bool IsWholeMonthValid { get; set; }

        /// <summary>
        /// 账单对手方咨询值类型(付款身份)咨询类型：PID/UID/MID/CID/NAME/OU
        /// </summary>
        [XmlElement("opposite_fund_type")]
        public string OppositeFundType { get; set; }

        /// <summary>
        /// 账单对手方咨询类型值(付款身份)咨询类型对应的值
        /// </summary>
        [XmlElement("opposite_fund_value")]
        public string OppositeFundValue { get; set; }

        /// <summary>
        /// 账单对手方咨询值类型(结算身份)咨询类型：PID/UID/MID/CID/NAME/OU
        /// </summary>
        [XmlElement("opposite_settle_type")]
        public string OppositeSettleType { get; set; }

        /// <summary>
        /// 账单对手方咨询类型值(结算身份)对应咨询值
        /// </summary>
        [XmlElement("opposite_settle_value")]
        public string OppositeSettleValue { get; set; }

        /// <summary>
        /// 本方咨询类型：PID/UID/MID/CID
        /// </summary>
        [XmlElement("self_type")]
        public string SelfType { get; set; }

        /// <summary>
        /// 根据咨询类型传入相应的咨询值
        /// </summary>
        [XmlElement("self_value")]
        public string SelfValue { get; set; }
    }
}
