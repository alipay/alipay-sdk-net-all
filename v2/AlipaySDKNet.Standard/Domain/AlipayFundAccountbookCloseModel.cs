using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFundAccountbookCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundAccountbookCloseModel : AopObject
    {
        /// <summary>
        /// 资金记账本ID，指定需要注销的资金记账本
        /// </summary>
        [XmlElement("account_book_id")]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 资金记账本的补充参数，根据当前业务场景的不同，实际传递会有差异，请根据实际业务场景来组织参数。
        /// </summary>
        [XmlElement("business_params")]
        public AccountCloseBusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 资金记账本场景，用于区分不同业务场景的记账本
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
