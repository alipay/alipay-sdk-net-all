using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceCommonAccountbookQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceCommonAccountbookQueryModel : AopObject
    {
        /// <summary>
        /// 商户账本id
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 页码，默认1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页大小，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 签约账户id
        /// </summary>
        [XmlElement("sign_user_id")]
        public string SignUserId { get; set; }

        /// <summary>
        /// 签约账户openId
        /// </summary>
        [XmlElement("sign_user_open_id")]
        public string SignUserOpenId { get; set; }
    }
}
