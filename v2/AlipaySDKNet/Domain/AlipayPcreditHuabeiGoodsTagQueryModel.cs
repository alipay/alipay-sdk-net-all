using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiGoodsTagQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiGoodsTagQueryModel : AopObject
    {
        /// <summary>
        /// 识别标识码
        /// </summary>
        [XmlElement("biz_src")]
        public string BizSrc { get; set; }
    }
}
