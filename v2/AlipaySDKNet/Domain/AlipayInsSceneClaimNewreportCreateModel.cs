using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneClaimNewreportCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneClaimNewreportCreateModel : AopObject
    {
        /// <summary>
        /// 申报原因 1:收货电话无法接通 2:收货地址不正确
        /// </summary>
        [XmlElement("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 申诉结果 1:成功 2:失败
        /// </summary>
        [XmlElement("apply_result")]
        public string ApplyResult { get; set; }

        /// <summary>
        /// 受益人
        /// </summary>
        [XmlElement("beneficiary")]
        public InsPerson Beneficiary { get; set; }

        /// <summary>
        /// 业务字段
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 外部报案金额(单位:分)
        /// </summary>
        [XmlElement("claim_fee")]
        public long ClaimFee { get; set; }

        /// <summary>
        /// 报案原因: 1:订单超时 2:物流取消订单； 3:商家切换自配送； 4:特殊申报单 备注:枚举可自定义
        /// </summary>
        [XmlElement("claim_report_reason")]
        public string ClaimReportReason { get; set; }

        /// <summary>
        /// 关联订单信息
        /// </summary>
        [XmlElement("order_info")]
        public InsOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 外部业务号(幂等字段)
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 产品号(一般由蚂蚁提供)
        /// </summary>
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 报案人
        /// </summary>
        [XmlElement("reporter")]
        public InsPerson Reporter { get; set; }
    }
}
