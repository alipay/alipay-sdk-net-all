using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiCateringMerchantTmallSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringMerchantTmallSyncModel : AopObject
    {
        /// <summary>
        /// 业务类型，标识商户操作类型是签约还是解约操作，枚举值：SIGN表示签约、UNSIGN表示解约
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 请求id，唯一，用于标识唯一请求，可用uuid生成
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
