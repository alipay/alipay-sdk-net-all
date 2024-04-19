using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCrowdBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCrowdBatchqueryModel : AopObject
    {
        /// <summary>
        /// 人群名称 最大长度为15个字符
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 页码，本参数为空或小于1默认显示第一页；
        /// </summary>
        [XmlElement("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 每页大小。本参数为空或小于1默认20条；超过20条默认按20条查询；不足20条则按实际记录数返回
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }
    }
}
