using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundJointaccountAccountlistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundJointaccountAccountlistQueryModel : AopObject
    {
        /// <summary>
        /// 授权协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 查询模式：本次仅支持MASTER
        /// </summary>
        [XmlElement("index_type")]
        public string IndexType { get; set; }

        /// <summary>
        /// 小荷包产品码，区分不同的小荷包类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
