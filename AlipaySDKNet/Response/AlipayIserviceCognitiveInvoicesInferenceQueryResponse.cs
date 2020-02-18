using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveInvoicesInferenceQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveInvoicesInferenceQueryResponse : AopResponse
    {
        /// <summary>
        /// 算法版本
        /// </summary>
        [XmlElement("algo_version")]
        public string AlgoVersion { get; set; }

        /// <summary>
        /// 增值税发票内容
        /// </summary>
        [XmlElement("content")]
        public TaxBillContent Content { get; set; }

        /// <summary>
        /// 当ret不为0，err_msg记录详细错误原因
        /// </summary>
        [XmlElement("err_msg")]
        public string ErrMsg { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        [XmlElement("ret")]
        public string Ret { get; set; }
    }
}
