using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserJobcardInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserJobcardInfoQueryModel : AopObject
    {
        /// <summary>
        /// 使用场景，如职位推荐
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 职位供应商code
        /// </summary>
        [XmlElement("job_supplier_code")]
        public string JobSupplierCode { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
