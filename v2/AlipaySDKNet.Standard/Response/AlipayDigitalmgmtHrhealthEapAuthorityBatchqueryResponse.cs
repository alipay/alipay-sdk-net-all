using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtHrhealthEapAuthorityBatchqueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtHrhealthEapAuthorityBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 该参数用来标识用户是否有权益以及用户所属团餐所属组织，是根据用户查询用户权益信息以及corp按照组织归属转换得来，供应商会依据此参数判断用户是否展示蚂蚁团餐内容
        /// </summary>
        [XmlArray("eap_auth_vo")]
        [XmlArrayItem("eap_auth_v_o")]
        public List<EapAuthVO> EapAuthVo { get; set; }
    }
}
