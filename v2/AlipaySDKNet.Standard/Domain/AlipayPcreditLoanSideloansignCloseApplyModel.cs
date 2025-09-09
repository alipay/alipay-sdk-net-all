using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditLoanSideloansignCloseApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanSideloansignCloseApplyModel : AopObject
    {
        /// <summary>
        /// 支付宝用户id，客户在支付宝的身份证
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 扩展字段JSONString，存放支付宝核身信息
        /// </summary>
        [XmlElement("extension")]
        public string Extension { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 蚂蚁借贷款产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 退出申请单号，外部业务单号幂等键
        /// </summary>
        [XmlElement("quit_credit_apply_no")]
        public string QuitCreditApplyNo { get; set; }

        /// <summary>
        /// 退出场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }
    }
}
