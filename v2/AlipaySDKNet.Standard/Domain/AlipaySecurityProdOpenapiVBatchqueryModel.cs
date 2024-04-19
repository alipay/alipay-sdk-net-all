using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdOpenapiVBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdOpenapiVBatchqueryModel : AopObject
    {
        /// <summary>
        /// 金额SDK目前直接消费字段的描述，若在描述中说明字段废弃和废弃原因，会自动同步SDK，无需另外开 当前字段已废弃(废弃测试下的文案的调查SDK目前直接消费字段的描述，若在描述中说明字段废弃和废弃原因，会自动同步SDK，无需另外开)
        /// </summary>
        [XmlElement("d_amount")]
        public string DAmount { get; set; }

        /// <summary>
        /// 特殊可选
        /// </summary>
        [XmlElement("dd")]
        public string Dd { get; set; }

        /// <summary>
        /// 所有文档可见 当前字段已废弃(萨达分VG不不不不不不不不不不不不不不不不不不不不不)
        /// </summary>
        [XmlElement("ddf")]
        public string Ddf { get; set; }

        /// <summary>
        /// 可选
        /// </summary>
        [XmlElement("jf")]
        public string Jf { get; set; }

        /// <summary>
        /// 必选
        /// </summary>
        [XmlElement("lk")]
        public string Lk { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitudedd")]
        public string Longitudedd { get; set; }

        /// <summary>
        /// 经度特殊可选
        /// </summary>
        [XmlElement("longitudeeee")]
        public CedsipeihuanCcomplex Longitudeeee { get; set; }

        /// <summary>
        /// 所有文档不可见 当前字段已废弃(热热热热热若若若若若若若若若若若若若若)
        /// </summary>
        [XmlElement("rr")]
        public string Rr { get; set; }

        /// <summary>
        /// 描述下这个字段（必选，所有文档可以见）
        /// </summary>
        [XmlElement("x_njd")]
        public bool XNjd { get; set; }
    }
}
