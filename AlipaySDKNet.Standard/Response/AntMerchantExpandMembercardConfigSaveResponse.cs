using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandMembercardConfigSaveResponse.
    /// </summary>
    public class AntMerchantExpandMembercardConfigSaveResponse : AopResponse
    {
        /// <summary>
        /// 商家的安心充配置的唯一编号； 如果是代配置模式不会立刻产生此编号，需要在确认之后；如果是自配置模式，会立刻产生此编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
