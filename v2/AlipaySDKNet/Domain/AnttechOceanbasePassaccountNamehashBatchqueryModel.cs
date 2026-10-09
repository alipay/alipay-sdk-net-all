using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbasePassaccountNamehashBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbasePassaccountNamehashBatchqueryModel : AopObject
    {
        /// <summary>
        /// 账号名称
        /// </summary>
        [XmlElement("account_name")]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 所有状态
        /// </summary>
        [XmlElement("name_hash_status")]
        public string NameHashStatus { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 一页返回数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 通行证id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
