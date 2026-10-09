using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarRentcarPreauthUnfreezeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarRentcarPreauthUnfreezeModel : AopObject
    {
        /// <summary>
        /// 解冻资金类型
        /// </summary>
        [XmlElement("fund_type")]
        public string FundType { get; set; }

        /// <summary>
        /// 支付宝用户开放平台id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部请求号，即商户请求车生活进行预授权资金解冻的流水号，车生活侧通过此字段进行幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 解冻金额，单位分
        /// </summary>
        [XmlElement("unfreeze_amount")]
        public long UnfreezeAmount { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
