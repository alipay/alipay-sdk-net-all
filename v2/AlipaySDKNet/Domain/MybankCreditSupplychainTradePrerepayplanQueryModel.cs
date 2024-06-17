using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainTradePrerepayplanQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainTradePrerepayplanQueryModel : AopObject
    {
        /// <summary>
        /// ISV 身份信息
        /// </summary>
        [XmlElement("buyer")]
        public Member Buyer { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 接口扩展信息
        /// </summary>
        [XmlElement("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// {isv_iprole_id}_${zhifutong_ar_no}
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 融租销售产品code
        /// </summary>
        [XmlElement("sale_pd_code")]
        public string SalePdCode { get; set; }
    }
}
