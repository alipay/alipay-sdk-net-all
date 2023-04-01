using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcServiceOrderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcServiceOrderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 订购主体ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 订购单ID列表
        /// </summary>
        [XmlArray("order_id_list")]
        [XmlArrayItem("string")]
        public List<string> OrderIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务ID列表
        /// </summary>
        [XmlArray("service_id_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// 服务类型列表
        /// </summary>
        [XmlArray("service_type_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceTypeList { get; set; }
    }
}
