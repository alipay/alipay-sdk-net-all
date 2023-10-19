using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemCategoryPreconsultResponse.
    /// </summary>
    public class AlipayOpenAppItemCategoryPreconsultResponse : AopResponse
    {
        /// <summary>
        /// 商品类目预测预咨询是否提交成功
        /// </summary>
        [XmlElement("status")]
        public bool Status { get; set; }
    }
}
