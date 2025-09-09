using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdPageprincipalQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdPageprincipalQueryModel : AopObject
    {
        /// <summary>
        /// 账户名称、账号、商户号模糊匹配
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商家状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
