using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmCrmNotifyrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmCrmNotifyrecordQueryModel : AopObject
    {
        /// <summary>
        /// 允许为空，为空时默认为1
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 查询id,可传入线索id或客户id或联系人id
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 表单code，仅允许传入DING_CUE，DING_CUSTOMER，DING_CONTACT之一
        /// </summary>
        [XmlElement("form_code")]
        public string FormCode { get; set; }

        /// <summary>
        /// 每页条数,允许为空，为空时默认为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 租户Id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }
    }
}
