using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorAmountConsultResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorAmountConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否可提额, status=1时必传（默认false）
        /// </summary>
        [XmlElement("can_credit_change")]
        public bool CanCreditChange { get; set; }

        /// <summary>
        /// 用户注销状态，枚举值： 0-正常， 1-已注销（已关闭退出）
        /// </summary>
        [XmlElement("cancel_status")]
        public long CancelStatus { get; set; }

        /// <summary>
        /// 支付宝账号已脱敏
        /// </summary>
        [XmlElement("cp_user_name")]
        public string CpUserName { get; set; }

        /// <summary>
        /// 额度管控截止时间, 时间戳(秒)，limitUseErrStatus=4返回
        /// </summary>
        [XmlElement("grey_expire_time")]
        public long GreyExpireTime { get; set; }

        /// <summary>
        /// 额度类型(默认是1循环额度)
        /// </summary>
        [XmlElement("limit_type")]
        public long LimitType { get; set; }

        /// <summary>
        /// 额度不可使用描述
        /// </summary>
        [XmlElement("limit_use_err_desc")]
        public string LimitUseErrDesc { get; set; }

        /// <summary>
        /// 额度不可使用状态，枚举值： 1-存在放款中借款， 2-存在逾期订单不可借款， 3-暂时无法支用 4-其他原因  机构维护不可用的情况：有预期内的维护时间给4，预期外的路由到3
        /// </summary>
        [XmlElement("limit_use_err_status")]
        public long LimitUseErrStatus { get; set; }

        /// <summary>
        /// 单笔借款最大金额，单位分，status=1时必传（默认返回总可用额度）
        /// </summary>
        [XmlElement("max_loan")]
        public string MaxLoan { get; set; }

        /// <summary>
        /// 单笔借款最小金额，单位分，status=1时必传（默认步长1元，没有小数点）
        /// </summary>
        [XmlElement("min_loan")]
        public string MinLoan { get; set; }

        /// <summary>
        /// 逾期信息, limitUseErrStatus=2必须要返回
        /// </summary>
        [XmlElement("overdue_info")]
        public HonorOverdueInfoDTO OverdueInfo { get; set; }

        /// <summary>
        /// 产品信息, status=1时必传
        /// </summary>
        [XmlArray("product_infos")]
        [XmlArrayItem("honor_product_info_d_t_o")]
        public List<HonorProductInfoDTO> ProductInfos { get; set; }

        /// <summary>
        /// 还款日
        /// </summary>
        [XmlElement("repay_day")]
        public long RepayDay { get; set; }

        /// <summary>
        /// 用户待还款信息，有未结清订单时返回
        /// </summary>
        [XmlElement("repay_info")]
        public HonorRepayInfoDTO RepayInfo { get; set; }

        /// <summary>
        /// 额度状态，枚举值： 1-正常,  2-审核中, （状态数据-授信申请中的返回审核中） 3-失效, （仅存在用户关闭场景） 4-拒绝
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 临额相关信息，如果有就返回
        /// </summary>
        [XmlElement("temp_limit_info")]
        public HonorTempLimitInfoDTO TempLimitInfo { get; set; }

        /// <summary>
        /// 总可用额度 (临额+固额总和)，单位分，status=1时必传
        /// </summary>
        [XmlElement("total_available_limit")]
        public string TotalAvailableLimit { get; set; }

        /// <summary>
        /// 总授信额度 (临额+固额总和)，单位分，status=1时必传
        /// </summary>
        [XmlElement("total_credit_limit")]
        public string TotalCreditLimit { get; set; }
    }
}
