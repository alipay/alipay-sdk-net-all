using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserBillDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserBillDetail : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_login_id")]
        public string AlipayLoginId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 税前金额，单位：人民币
        /// </summary>
        [XmlElement("amount_before_tax")]
        public string AmountBeforeTax { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_cert_no")]
        public string IdCertNo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户单据编号，全局唯一，可以用来做幂等
        /// </summary>
        [XmlElement("user_bill_no")]
        public string UserBillNo { get; set; }
    }
}
