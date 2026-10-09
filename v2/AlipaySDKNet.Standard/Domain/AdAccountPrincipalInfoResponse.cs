using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AdAccountPrincipalInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AdAccountPrincipalInfoResponse : AopObject
    {
        /// <summary>
        /// 支付宝账号
        /// </summary>
        [XmlElement("alipay_account")]
        public string AlipayAccount { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [XmlElement("alipay_oid")]
        public string AlipayOid { get; set; }

        /// <summary>
        /// 灯火一级类目id
        /// </summary>
        [XmlElement("first_trade_id")]
        public string FirstTradeId { get; set; }

        /// <summary>
        /// 灯火一级类目名称
        /// </summary>
        [XmlElement("first_trade_name")]
        public string FirstTradeName { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 投放端商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("principal_name")]
        public string PrincipalName { get; set; }

        /// <summary>
        /// 灯火二级类目id
        /// </summary>
        [XmlElement("second_trade_id")]
        public string SecondTradeId { get; set; }

        /// <summary>
        /// 灯火二级类目名称
        /// </summary>
        [XmlElement("second_trade_name")]
        public string SecondTradeName { get; set; }

        /// <summary>
        /// 商家状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 商家状态名称
        /// </summary>
        [XmlElement("status_name")]
        public string StatusName { get; set; }
    }
}
