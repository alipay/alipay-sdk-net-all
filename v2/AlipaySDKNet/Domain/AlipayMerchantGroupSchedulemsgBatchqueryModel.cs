using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantGroupSchedulemsgBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantGroupSchedulemsgBatchqueryModel : AopObject
    {
        /// <summary>
        /// 消息id 
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 当前第几页 
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大展示50条 
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
