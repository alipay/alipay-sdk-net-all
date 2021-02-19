using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinancialnetAuthExpressSigncardQueryResponse.
    /// </summary>
    public class AlipayFinancialnetAuthExpressSigncardQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务成功时，且用户有相应的卡，该字段（列表类型）存在
        /// </summary>
        [XmlArray("sign_card_infos")]
        [XmlArrayItem("sign_card_info")]
        public List<SignCardInfo> SignCardInfos { get; set; }
    }
}
