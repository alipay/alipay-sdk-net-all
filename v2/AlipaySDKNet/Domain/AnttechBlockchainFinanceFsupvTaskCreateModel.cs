using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceFsupvTaskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceFsupvTaskCreateModel : AopObject
    {
        /// <summary>
        /// 资金管控任务产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("fund_supv_product_code")]
        public string FundSupvProductCode { get; set; }

        /// <summary>
        /// 交易标的编号，按照实际交易对象编号填写。如网约车场景下为该四轮车车架号
        /// </summary>
        [XmlElement("obj_number")]
        public string ObjNumber { get; set; }

        /// <summary>
        /// 标的交易结束时间
        /// </summary>
        [XmlElement("obj_trade_end")]
        public string ObjTradeEnd { get; set; }

        /// <summary>
        /// 标的交易分期金额，单位为元；在租赁交易下为每期的租金
        /// </summary>
        [XmlElement("obj_trade_install_amount")]
        public string ObjTradeInstallAmount { get; set; }

        /// <summary>
        /// 标的交易编号，根据实际标的交易时的交易编号填写
        /// </summary>
        [XmlElement("obj_trade_no")]
        public string ObjTradeNo { get; set; }

        /// <summary>
        /// 标的交易结算周期类型，在租赁交易下为租金结算周期
        /// </summary>
        [XmlElement("obj_trade_settle_period_type")]
        public string ObjTradeSettlePeriodType { get; set; }

        /// <summary>
        /// 标的交易起始时间
        /// </summary>
        [XmlElement("obj_trade_start")]
        public string ObjTradeStart { get; set; }

        /// <summary>
        /// 标的交易类型，根据实际标的交易时的交易类型填写
        /// </summary>
        [XmlElement("obj_trade_type")]
        public string ObjTradeType { get; set; }

        /// <summary>
        /// 交易标的类型，按照实际交易时标的类型填写
        /// </summary>
        [XmlElement("obj_type")]
        public string ObjType { get; set; }

        /// <summary>
        /// 交易请求号，以yyyyMMdd时间串格式开始，在调用方系统内需要保持全局唯一，是判断幂等逻辑请求唯一识别码。
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 被管控方证件号码，按实际场景获取
        /// </summary>
        [XmlElement("supervised_id_number")]
        public string SupervisedIdNumber { get; set; }

        /// <summary>
        /// 被管控方证件类型，按照枚举中的实际值进行填写
        /// </summary>
        [XmlElement("supervised_id_type")]
        public string SupervisedIdType { get; set; }

        /// <summary>
        /// 被管控方名称，按照被管控方实际名称获取
        /// </summary>
        [XmlElement("supervised_name")]
        public string SupervisedName { get; set; }

        /// <summary>
        /// 管控方证件号码
        /// </summary>
        [XmlElement("supervisor_id_number")]
        public string SupervisorIdNumber { get; set; }

        /// <summary>
        /// 管控方证件类型，根据实际场景按照枚举值中的类型进行填写
        /// </summary>
        [XmlElement("supervisor_id_type")]
        public string SupervisorIdType { get; set; }

        /// <summary>
        /// 管控方名称，按实际场景中管控方名称填写
        /// </summary>
        [XmlElement("supervisor_name")]
        public string SupervisorName { get; set; }
    }
}
