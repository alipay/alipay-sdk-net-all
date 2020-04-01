using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantContractPageQueryResponse.
    /// </summary>
    public class ZhimaMerchantContractPageQueryResponse : AopResponse
    {
        /// <summary>
        /// 合约详情信息
        /// </summary>
        [XmlArray("biz_data")]
        [XmlArrayItem("zm_contract_detail")]
        public List<ZmContractDetail> BizData { get; set; }

        /// <summary>
        /// 业务结果描述，成功则为空，失败才会有
        /// </summary>
        [XmlElement("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务成功标识，success/failed
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }
    }
}
