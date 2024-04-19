using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CreditPhoneInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CreditPhoneInfo : AopObject
    {
        /// <summary>
        /// 单位是元。套餐每月保底金额
        /// </summary>
        [XmlElement("busi_level")]
        public string BusiLevel { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        [XmlElement("busi_name")]
        public string BusiName { get; set; }

        /// <summary>
        /// 套餐类型
        /// </summary>
        [XmlElement("busi_type")]
        public string BusiType { get; set; }

        /// <summary>
        /// 若当月【due_date】日前未缴纳上月套餐费
        /// </summary>
        [XmlElement("due_date")]
        public long DueDate { get; set; }

        /// <summary>
        /// 分期数，决定了最大的分期扣款数。注意，提前结清认为是一笔特殊的分期扣款。
        /// </summary>
        [XmlElement("installment_numbers")]
        public long InstallmentNumbers { get; set; }

        /// <summary>
        /// 办理合约手机号对应的运营商
        /// </summary>
        [XmlElement("isp_abbr_cn")]
        public string IspAbbrCn { get; set; }

        /// <summary>
        /// 单位是元。单期最大扣款金额。注意单期最大扣款金额*分期数不得超过订单总金额
        /// </summary>
        [XmlElement("max_amount_per_installment")]
        public string MaxAmountPerInstallment { get; set; }

        /// <summary>
        /// 连续欠费达【overdue_days】天
        /// </summary>
        [XmlElement("overdue_days")]
        public long OverdueDays { get; set; }

        /// <summary>
        /// 于【pay_date】日扣除本月已享优惠
        /// </summary>
        [XmlElement("pay_date")]
        public long PayDate { get; set; }

        /// <summary>
        /// 单位是元。原套餐每月保底金额
        /// </summary>
        [XmlElement("pre_busi_level")]
        public string PreBusiLevel { get; set; }

        /// <summary>
        /// 办理合约手机号对应的省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 签约合约机套餐的手机号
        /// </summary>
        [XmlElement("service_mobile")]
        public string ServiceMobile { get; set; }

        /// <summary>
        /// 机构只允许传入事先已通过审批的套餐类目ID。套餐类目中中包含信用购机套餐的基本属性。
        /// </summary>
        [XmlElement("spu_id")]
        public string SpuId { get; set; }

        /// <summary>
        /// 单位是元。套餐优总惠金额是用户享受的全部优惠金额。同时用于计算服务手续费（冻结金额-套餐总优惠金额）
        /// </summary>
        [XmlElement("total_bonus")]
        public string TotalBonus { get; set; }
    }
}
