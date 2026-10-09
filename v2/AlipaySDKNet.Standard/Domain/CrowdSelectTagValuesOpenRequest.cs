using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CrowdSelectTagValuesOpenRequest Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdSelectTagValuesOpenRequest : AopObject
    {
        /// <summary>
        /// 标签ID，取自alipay.merchant.qipan.crowdtag.query接口tag_id字段
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }

        /// <summary>
        /// 标签可选项范围分类ID，取自alipay.merchant.qipan.crowdtag.query接口tag_option_category_id字段  <a href="https://opendocs.alipay.com/pre-open/04phhq" target="_blank">私域资产标签值参考标签说明</a>
        /// </summary>
        [XmlElement("tag_option_category_id")]
        public string TagOptionCategoryId { get; set; }

        /// <summary>
        /// 标签值多个用,号分割，注意用英文逗号！！标签值取自alipay.merchant.qipan.crowdtag.query接口value字段
        /// </summary>
        [XmlElement("values")]
        public string Values { get; set; }
    }
}
