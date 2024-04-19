using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainDefinTradeQueryModel : AopObject
    {
        /// <summary>
        /// 企业/报关单查询请求 in Json string
        /// </summary>
        [XmlElement("encoded_biz_param")]
        public string EncodedBizParam { get; set; }

        /// <summary>
        /// sys_param, 按其中字段function区分查询类型，如企业认证还是报关单查询。
        /// </summary>
        [XmlElement("sys_param")]
        public SystemParam SysParam { get; set; }
    }
}
