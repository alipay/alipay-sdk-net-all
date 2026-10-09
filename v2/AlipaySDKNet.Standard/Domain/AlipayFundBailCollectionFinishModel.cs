using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundBailCollectionFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundBailCollectionFinishModel : AopObject
    {
        /// <summary>
        /// 代扣协议号，对应唯一的保证金代扣协议及保证金资金池
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 业务扩展参数，用于商户的特定业务信息的传递，json格式。
        /// </summary>
        [XmlElement("extra_param")]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 外部委托号，对应唯一的委托案件
        /// </summary>
        [XmlElement("out_collection_no")]
        public string OutCollectionNo { get; set; }

        /// <summary>
        /// 催收案件主体，请输入2088开头的16位uid
        /// </summary>
        [XmlElement("principal_open_id")]
        public string PrincipalOpenId { get; set; }

        /// <summary>
        /// 催收案件主体，请输入2088开头的16位uid
        /// </summary>
        [XmlElement("principal_user_id")]
        public string PrincipalUserId { get; set; }

        /// <summary>
        /// 销售产品码，用于接入保证金业务，本字段取值固定为BAIL_AUTH
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
