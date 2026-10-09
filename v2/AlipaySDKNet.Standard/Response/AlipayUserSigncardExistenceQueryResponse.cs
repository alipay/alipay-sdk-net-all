using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserSigncardExistenceQueryResponse.
    /// </summary>
    public class AlipayUserSigncardExistenceQueryResponse : AopResponse
    {
        /// <summary>
        /// 是否已经签约快捷或卡通，只统计已激活的签约信息。T代表是，F代表否。
        /// </summary>
        [XmlElement("sign_card_exist")]
        public string SignCardExist { get; set; }
    }
}
