using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAntlegalchainTextnotaryCreateResponse.
    /// </summary>
    public class AlipayBossProdAntlegalchainTextnotaryCreateResponse : AopResponse
    {
        /// <summary>
        /// 通过app_code和business_unique_id确定唯一的id，使得上链串行,无返回则说明上链失败，返回只能说明初始化存证成功，不表示上链成功
        /// </summary>
        [XmlElement("biz_bas_id")]
        public string BizBasId { get; set; }
    }
}
