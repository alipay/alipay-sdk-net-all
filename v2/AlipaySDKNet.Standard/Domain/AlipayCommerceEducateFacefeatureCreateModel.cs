using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateFacefeatureCreateModel : AopObject
    {
        /// <summary>
        /// 行业编码。（注：该接口为定向开放接口，使用前需要与对应的"业务产品"申请，切勿随意填写）
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 机构编号。（同：机构id/机构内标）
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// isv英文简称。（注：请不要填写中文名称）
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 唯一标识ID
        /// </summary>
        [XmlElement("unique_id")]
        public string UniqueId { get; set; }
    }
}
